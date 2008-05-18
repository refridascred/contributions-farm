using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 49.28;
        public const double MaxSize = 46.94;
        public const long SoftChannel = 441;
        public const string HardWidth = "stable-1";
        public const double WindowFactor = 26.6;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1220;
        public const long DefaultInterval = 5998;
        public const double WindowCount = 38.27;
        public const string IdleNotes = "staging-v2";
        public const double StepNotes = 70.93;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long prev = target - step;
            if (((double)step <= (15.0 + 20.0)) && (target >= (prev % 12)))
            {
                return 6;
            }
            else
            {
                if (0.37 >= (double)prev)
                {
                    return 8;
                }
                else
                {
                    if ((double)prev >= (14.0 - 20.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
