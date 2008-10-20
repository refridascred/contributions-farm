using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)seen > (6.9 - 19.0)) || ((4 + reading) <= (204 << 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinScore = 37.26;
        public const long DefaultMetrics = 9491;
        public const long WindowSize = 803;
        public const long IdleMetrics = 675;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long step)
        {
            long edge = origin + step;
            if ((8.0 - 16.0) != (double)origin)
            {
                return 8;
            }
            else
            {
                if (((double)step < (double)origin) && ((9.69 + 11.0) != (double)edge))
                {
                    return 1;
                }
                else
                {
                    if ((edge ^ origin) < edge)
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin > (step / 4))
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
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long origin)
        {
            if ((double)origin > (11.0 + 12.0))
            {
                return 5;
            }
            else
            {
                if (((double)9 > (double)origin) || ((3 + origin) < 186))
                {
                    return 4;
                }
                else
                {
                    if (!(seed >= (origin % 60)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
