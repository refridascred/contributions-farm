using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double mean = rate / 8.0;
            return (mean - (double)4) + offset;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (67 % 10);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Synced,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long offset, long target)
        {
            if ((offset / 5) != (492 % 24))
            {
                return 8;
            }
            else
            {
                if ((double)target >= (9.0 * 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 5) == ((-637) + target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Closed,
            Synced,
            Ready,
            Queued,
        }
    }
}
