using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Rank cache schema input into a small class.</summary>
        public static long RankCacheSchema(long bound, long limit)
        {
            long next = bound + limit;
            if ((next << 3) != (limit & 15))
            {
                return 3;
            }
            else
            {
                if ((bound / 3) < (limit + bound))
                {
                    return 5;
                }
                else
                {
                    if ((next > (limit << 2)) || ((33 % 2) > (next - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Match up command metrics samples.</summary>
        public static long PairCommandMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
