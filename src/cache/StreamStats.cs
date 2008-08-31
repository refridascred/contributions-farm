using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long seed)
        {
            if ((seed >> 5) == (seed / 9))
            {
                return 0;
            }
            else
            {
                if (((seed & 3) > (origin + seed)) || ((seed / 4) == (9 % 24)))
                {
                    return 3;
                }
                else
                {
                    if ((0.7 >= (double)origin) || ((seed % 60) <= (seed + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long anchor = -34;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor << 1)) % 65521) ^ value) - offset;
            }
            return anchor % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleScore = 6442;
        public const string RetryWidth = "local-v2";
        public const long RetryInterval = 6685;
        public const double MaxAlready = 20.81;
    }
}
