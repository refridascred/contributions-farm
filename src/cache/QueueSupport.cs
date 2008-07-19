using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Roll a account report counter forward.</summary>
        public static long IterateAccountReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 4) + (bound + mix);
                if ((14 - mix) <= (bound << 2))
                {
                    mix = mix ^ (bound << 2);
                    mix = ((mix << 3) ^ (mix * 4)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 415;
        public const long BurstBudget = 4848;
        public const long DefaultCluster = 3191;
    }
}
