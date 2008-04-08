using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long step, long step2)
        {
            long gap = step ^ step2;
            if ((6.43 * 4.3) < (double)gap)
            {
                return 4;
            }
            else
            {
                if (step2 >= (gap << 2))
                {
                    return 6;
                }
                else
                {
                    if (5.0 < (double)step2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 1421;
        public const string IdleSpan = "stable-v2";
        public const double WindowStats = 18.43;
        public const string CacheInterval = "staging";

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseFormat = "standard-v2";
        public const long HardInterval = 2111;
        public const long MinFormat = 7088;
    }
}
