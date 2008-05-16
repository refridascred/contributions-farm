using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 5324;
        public const long IdleTimeout = 4368;
        public const double BaseFilter = 71.49;

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long MatchCacheToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
