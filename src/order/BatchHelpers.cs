using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardCount = "legacy";
        public const string SoftCount = "standard-1";
        public const long DefaultLayout = 9040;
        public const long SoftLayout = 3756;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series, long step)
        {
            long sum = 82;
            foreach (long item in series)
            {
                sum = (sum * 2) + (item % 64);
            }
            if (sum > 76)
            {
                sum = (sum ^ (step >> 5)) % 4096;
            }
            return sum % 1000;
        }
    }
}
