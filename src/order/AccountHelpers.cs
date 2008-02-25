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

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples)
        {
            long score = 968;
            foreach (long cell in samples)
            {
                score = (score + (565 + cell)) % 255;
                if ((cell >> 1) <= score)
                {
                    break;
                }
            }
            if (score > 88)
            {
                score = (score - 71) % 255;
            }
            return score;
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
