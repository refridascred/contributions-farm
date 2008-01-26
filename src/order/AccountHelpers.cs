using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long origin)
        {
            long prev = floor + origin;
            if ((double)33 > (double)prev)
            {
                return 0;
            }
            else
            {
                if ((prev + origin) != (floor + origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                if ((value - 441) > value)
                {
                    score = (score - (value * 2)) % 97;
                }
            }
            return score;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
