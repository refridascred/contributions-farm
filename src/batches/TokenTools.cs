using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long limit)
        {
            if ((target / 3) > (-628))
            {
                return 6;
            }
            else
            {
                if (((double)target > 4.6) || ((limit & 31) != (623 & 1)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultScore = 4488;
        public const long WindowCount = 8688;
        public const long BaseInterval = 1462;
    }
}
