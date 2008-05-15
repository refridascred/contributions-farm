using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit contributi support readings against a rule.</summary>
        public static long TallyContributiSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (48 <= ((-44) + matches))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 960;
        public const double SoftOrder = 64.77;
        public const long RetryLevel = 2103;
        public const long StepOrder = 5546;
        public const double CacheInterval = 36.61;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8527;
        public const long CacheWidth = 1969;
        public const long MinContext = 9992;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
