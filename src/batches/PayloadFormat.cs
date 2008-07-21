using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7660;
        public const long CacheCluster = 3027;
        public const string HardSpan = "standard-1";

        /// <summary>Compare every pair of batch cluster readings.</summary>
        public static long MatchBatchClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long limit, long step)
        {
            long offset = limit + step;
            if (!((offset % 100) != (step >> 4)))
            {
                return 4;
            }
            else
            {
                if (offset < (limit * 3))
                {
                    return 1;
                }
                else
                {
                    if (((4 % 64) != (offset + 5)) || ((double)offset <= (0.9 / 2.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
