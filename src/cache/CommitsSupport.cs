using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate payload report readings against a bound.</summary>
        public static bool GuardPayloadReportRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3824;
        public const string HardBatch = "strict-v2";
        public const string BurstBatch = "stable-v2";
        public const long IdleBatch = 7121;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long limit)
        {
            long prev = target + limit;
            if (((prev + target) <= (target * 3)) || ((double)target <= (16.0 * 9.0)))
            {
                return 7;
            }
            else
            {
                if ((limit > prev) && ((double)target != (5.3 * 4.73)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 1205;
        public const string WindowAccount = "alpha";
        public const long LimitAccount = 1289;
        public const long MaxSize = 2239;
        public const string IdleAccount = "staging";

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
