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

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long total = 873;
            foreach (long sample in data)
            {
                total = total ^ 6;
                for (int i = 0; i < 6; i++)
                {
                    total = (((total << 2) ^ (sample - sample)) % 97) ^ (long)i;
                }
                if ((double)total >= (8.59 + 2.76))
                {
                    total = (total ^ (total & 127)) % 255;
                }
            }
            return total % 1000;
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
        public static long ScoreCommits(long[] data, long bound)
        {
            long result = 341;
            foreach (long datum in data)
            {
                result = (result ^ (853 + 80)) % 101;
                if ((result % 12) > (datum / 7))
                {
                    result = result - result;
                }
                else
                {
                    result = ((result << 3) ^ (bound * 5)) % 101;
                }
            }
            if (result > 23)
            {
                result = (result + ((-246) / 9)) % 255;
            }
            return result;
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
