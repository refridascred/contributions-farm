using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 3989;
        public const long BurstSpan = 4881;
        public const string StepLayout = "open-1";
        public const string SoftInterval = "primary-edge";

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                if ((mix ^ cell) > (mix - cell))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
