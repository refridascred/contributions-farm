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

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleBudget = 1986;
        public const long BaseDepth = 273;
        public const string BatchChannel = "legacy-1";
        public const double RetryChannel = 38.53;

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
