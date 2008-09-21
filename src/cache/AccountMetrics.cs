using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9431;
        public const long DefaultCount = 1994;
        public const long BaseWindow = 320;
        public const long MinTimeout = 7037;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleScore = 17.36;
        public const long BatchFactor = 9195;
        public const string StepSize = "staging-edge";
        public const double MaxQueue = 88.25;
        public const double WindowQueue = 94.05;

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowTimeout = 89.82;
        public const long BurstInterval = 1763;
        public const long RetryEntry = 1899;
        public const long MinWidth = 6846;
        public const long BaseWidth = 271;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ sample) % 255;
            }
            if (sum > (-90))
            {
                sum = ((sum << 3) ^ (sum / 5)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long offset, long step)
        {
            if (!((826 >> 2) <= (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if (((offset - step) >= step) && (3.0 >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((offset + step) == (step - (-65))))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step > (step << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
