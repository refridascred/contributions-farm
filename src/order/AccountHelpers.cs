using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result + 89) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of route githubfarm readings.</summary>
        public static long MatchRouteGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstCount = 52.53;
        public const long BatchTimeout = 6358;
        public const double BatchBudget = 48.63;
        public const long BatchScore = 7832;
        public const long HardFactor = 4829;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultTimeout = "standard-1";
        public const long BaseCache = 9769;
        public const string MinCache = "strict-v2";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
