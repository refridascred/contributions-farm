using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4734;
        public const long DefaultOrder = 4607;
        public const long RetrySize = 7420;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
