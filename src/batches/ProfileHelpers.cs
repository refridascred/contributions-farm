using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((long)i < (offset - sum)))
                {
                    sum = sum - (offset & 15);
                }
                sum = (sum ^ (offset / 3)) % 4096;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + (floor / 8.0)) + bias;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if (9.0 > (double)bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 * 3) != (bound ^ (-2)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Stale,
            Locked,
            Active,
        }
    }
}
