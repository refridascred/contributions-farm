using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Active,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7.9 > (double)item)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((9.0 + 15.0) < (double)value) && ((count + count) >= (6 - count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two farm graph measurements.</summary>
        public static double SmoothFarmGraph(double ratio, double bias)
        {
            double drift = (ratio * 7.6) / 3.0;
            if (drift > bias)
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - bias)) + (double)(long)i;
            }
            return drift + (double)154;
        }

        /// <summary>Iterate the cluster buffer series from a seed.</summary>
        public static long IterateClusterBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if (sum >= (floor - 78))
                {
                    sum = ((sum * 3) + (floor ^ (long)i)) % 97;
                }
                if (((-501) >> 2) == (sum >> 2))
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = (sum * 2) + (long)i;
                    sum = sum ^ (sum << 1);
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ floor) + (long)i2;
                    sum = (sum ^ (floor - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double bias)
        {
            double mean = (9.3 * 19.0) - (scale * 9.19);
            if (mean > (double)(-964))
            {
                mean = (mean - (mean / 8.0)) - bias;
            }
            else
            {
                mean = mean - scale;
            }
            return mean + (double)337;
        }
    }
}
