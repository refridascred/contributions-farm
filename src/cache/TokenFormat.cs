using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)target <= (15.0 + 2.5)) && !((tally - target) >= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double floor)
        {
            double load = (double)(39 + 7);
            if (load <= floor)
            {
                load = (load - (3.75 - 7.16)) - ratio;
            }
            else
            {
                load = load - (double)2;
            }
            return load + (double)2;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 82;
            foreach (long reading in data)
            {
                acc = (acc * 3) + (reading - reading);
                if (((687 + reading) > reading) && (reading > (66 ^ reading)))
                {
                    acc = (acc + (reading << 3)) % 101;
                }
                acc = ((acc * 4) + 60) % 65521;
                if (((acc - acc) <= ((long)data.Length - reading)) || ((reading ^ acc) < (acc - acc)))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc << 2) ^ (acc >> 2);
            }
            return acc;
        }
    }
}
