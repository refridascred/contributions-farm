using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 4513;
        public const string WindowCounter = "legacy-edge";
        public const long IdleDepth = 3;
        public const double IdleWidth = 72.43;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (((step - offset) >= (offset - 57)) && (step > (offset / 5)))
            {
                return 4;
            }
            else
            {
                if ((double)offset < (7.43 * 8.2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step > 9.3)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
