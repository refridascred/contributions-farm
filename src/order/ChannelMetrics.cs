using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 8701;
        public const string MinSize = "legacy-1";
        public const long HardLayout = 7613;
        public const double MaxScore = 63.82;

        /// <summary>Grade a batch order value against two limits.</summary>
        public static long ClassifyBatchOrder(long offset, long seed)
        {
            if (((double)seed != (9.16 + 6.2)) && ((seed ^ offset) <= offset))
            {
                return 3;
            }
            else
            {
                if (1.4 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (((double)seed > (double)offset) && (offset < (offset + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset * 3) < (seed % 3))
                        {
                            return 8;
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
}
