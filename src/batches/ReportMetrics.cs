using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "latest-edge";
        public const long WindowProfile = 5799;
        public const long HardProfile = 2850;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long lane = step ^ offset;
            if (7.9 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((lane >> 3) <= (step - offset))
                {
                    return 3;
                }
                else
                {
                    if (((lane / 6) != (offset / 4)) || ((494 + offset) > (offset ^ step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every buffer order entry stays within the limit.</summary>
        public static bool ValidateBufferOrderRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
