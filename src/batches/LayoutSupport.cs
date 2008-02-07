using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= 5.38)
            {
                ratio = ratio - floor;
            }
            return ratio - scale;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9998;
        public const long SoftChecks = 4969;
        public const long MinScore = 3509;
        public const string LimitChecks = "legacy-1";
        public const string IdleChecks = "primary-edge";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Queued,
            Idle,
            Locked,
            Paused,
        }
    }
}
