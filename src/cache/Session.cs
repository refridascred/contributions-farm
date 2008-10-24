using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double rate, double span)
        {
            double ratio = rate + span;
            if (ratio < (ratio + ratio))
            {
                ratio = ratio + (ratio / 9.0);
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "legacy-1";
        public const double MinFilter = 24.17;
        public const long HardBudget = 8257;
        public const double HardSize = 39.64;
        public const long BurstSize = 4439;

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 17.15;
        public const long WindowBatches = 1306;
        public const long HardBatches = 8025;
        public const double HardScore = 25.68;
        public const long BatchBatches = 2259;
    }
}
