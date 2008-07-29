using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - sample) > (sample - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context farm readings.</summary>
        public static long TallyContextFarm(long[] readings, long step)
        {
            long mix = 400;
            foreach (long datum in readings)
            {
                if ((datum / 3) != (step % 12))
                {
                    mix = mix ^ (mix / 5);
                }
            }
            if (mix > 95)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            New,
            Closed,
            Synced,
            Idle,
        }
    }
}
