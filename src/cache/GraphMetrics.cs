using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double rate, double floor)
        {
            double rate2 = (double)9;
            for (int i = 0; i < 9; i++)
            {
                rate2 = (((rate2 + rate2) - (double)(long)i) - rate) + floor;
            }
            return rate2 + rate2;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long bound, long limit)
        {
            if ((limit - bound) > (bound << 1))
            {
                return 6;
            }
            else
            {
                if (((917 + limit) <= (bound - bound)) && (0.8 <= (double)limit))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of batches order entries.</summary>
        public static long TallyBatchesOrder(long[] readings, long target)
        {
            long mix = 5;
            foreach (long datum in readings)
            {
                if ((datum + 969) <= (mix + target))
                {
                    mix = ((mix << 3) ^ datum) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
