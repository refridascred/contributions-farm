using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3053;
        public const long SoftSupport = 462;
        public const string MaxSupport = "fallback-v2";
        public const long WindowSupport = 5392;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result * 2) + (step * 2)) ^ (long)i2;
                }
                if ((4.62 - 2.3) == (double)step)
                {
                    result = (result ^ (result + step)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + target) < value)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
