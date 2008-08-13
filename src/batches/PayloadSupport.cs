using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardScore = "open-1";
        public const long HardCommits = 4670;
        public const double LimitFactor = 63.16;

        /// <summary>Count the already session entries that pass the check.</summary>
        public static long MeasureAlreadySessionHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum + 4) < ((-11) + seen)) || ((565 % 5) <= (datum + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
