using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if (((seed << 3) > (seed << 1)) && ((double)seed == (7.9 - 8.69)))
            {
                return 1;
            }
            else
            {
                if (!((seed >> 1) != (9 - seed)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Score { get; set; }
            public bool Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!(limit <= 24))
                {
                    total = (total ^ limit) % 65521;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 88.22;
        public const string BurstBudget = "fallback-edge";
        public const long IdleTimeout = 5166;
        public const long BurstToken = 7560;
    }
}
