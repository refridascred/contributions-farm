using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxDepth = 73.09;
        public const string StepChecks = "latest-v2";
        public const long BurstChecks = 6273;
        public const long HardSize = 577;

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double scale, double bias)
        {
            double rate = (double)(-500) + bias;
            if (rate > (2.3 - rate))
            {
                rate = rate - bias;
            }
            return rate - (bias - scale);
        }

        /// <summary>Fold a list of layout context readings.</summary>
        public static long CombineLayoutContext(long[] items, long target)
        {
            long state = 7;
            foreach (long cell in items)
            {
                if ((double)target <= (double)(-2))
                {
                    state = (state - target) - cell;
                }
            }
            return state;
        }
    }
}
