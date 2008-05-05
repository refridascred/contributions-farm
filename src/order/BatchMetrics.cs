using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 59.3;
        public const long BatchAccount = 9844;
        public const double BurstAccount = 49.5;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            if ((1.5 - 3.6) > (double)bound)
            {
                return 2;
            }
            else
            {
                if ((seed ^ bound) < seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double drift = floor;
            if (drift <= drift)
            {
                drift = (drift - 1.94) - ratio;
            }
            else
            {
                drift = drift - (floor * 9.1);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + (floor * 20.0);
        }

        /// <summary>Audit cache queue readings against a rule.</summary>
        public static long TallyCacheQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value <= (17.0 * 3.9))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long floor)
        {
            long total = 796;
            foreach (long entry in values)
            {
                if (!((total >> 3) > ((long)values.Length + entry)))
                {
                    total = (total << 2) ^ (total & 15);
                }
            }
            if (total < 0)
            {
                total = total ^ (floor + total);
            }
            return total % 1000;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((71 >> 3) >= (long)i)
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
