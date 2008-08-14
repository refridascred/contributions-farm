using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 6333;
        public const double CacheSpan = 47.56;
        public const double BurstQueue = 9.79;
        public const long HardQueue = 3227;
        public const long BatchQueue = 8384;

        /// <summary>Scale a metrics channel figure with a bias.</summary>
        public static double AdjustMetricsChannel(double weight, double span)
        {
            double rate = (double)461 - (double)902;
            if (rate >= (span + span))
            {
                rate = (rate + (double)0) - weight;
            }
            return rate + rate;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            long lane = step ^ floor;
            if ((lane + step) >= lane)
            {
                return 5;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((lane % 24) < (floor + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultCount = 1413;
        public const long WindowLevel = 8967;
        public const long BatchGraph = 491;
        public const string IdleGraph = "cached-edge";
    }
}
