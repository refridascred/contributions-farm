using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSize = 2.68;
        public const double DefaultLevel = 64.01;
        public const string MaxSupport = "standard";
        public const double BurstSupport = 38.2;
        public const long BatchSupport = 528;

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long seed, long origin)
        {
            if ((138 * 2) <= (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((4.9 > (double)origin) && ((double)seed > (7.1 + 9.3)))
                {
                    return 2;
                }
                else
                {
                    if (!((8.18 - 6.6) >= (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed - origin) == (seed + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
