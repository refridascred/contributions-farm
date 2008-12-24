using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long bound)
        {
            long mix = 689;
            foreach (long cell in samples)
            {
                if ((cell * 5) <= (cell + mix))
                {
                    mix = (((mix * 2) + (3 % 7)) % 1000) - bound;
                }
            }
            return mix;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Retry,
            Paused,
        }
    }
}
