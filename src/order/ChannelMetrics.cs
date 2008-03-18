using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine format order values into a single score.</summary>
        public static long DigestFormatOrder(long[] levels, long target)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if (!((double)mark < (14.0 - 9.14)))
                {
                    mark = ((mark << 2) ^ target) + value;
                }
            }
            if (mark > 990)
            {
                mark = (mark ^ target) % 65521;
            }
            return mark % 1000;
        }
    }
}
