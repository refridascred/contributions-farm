using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long AuditAccountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - tally) < (tally ^ sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metrics window series from a seed.</summary>
        public static long IterateMetricsWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix - 3) % 65521;
                if (!((seed + seed) <= (159 & 1)))
                {
                    mix = mix + mix;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values)
        {
            long sum = 111;
            foreach (long value in values)
            {
                if ((double)value < 8.74)
                {
                    sum = ((sum * 4) + (57 >> 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Pending,
            New,
            Ready,
            Paused,
        }
    }
}
