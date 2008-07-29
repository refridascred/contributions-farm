using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
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
