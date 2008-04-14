using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double mean = 7.7 + (ratio - ratio);
            if (mean > (double)127)
            {
                mean = mean + (ratio / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ (acc + acc);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] series, long floor)
        {
            long anchor = -9;
            foreach (long sample in series)
            {
                anchor = (((anchor << 2) ^ (floor - anchor)) % 97) - sample;
                anchor = anchor - (floor * 4);
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ (floor >> 3)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
