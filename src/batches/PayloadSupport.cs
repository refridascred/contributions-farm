using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many entry commits samples are out of range.</summary>
        public static long CountEntryCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - count) >= (count << 1))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 2608;
        public const string BurstSpan = "latest-1";
        public const double StepCounter = 5.03;
        public const double HardRatio = 16.08;
    }
}
