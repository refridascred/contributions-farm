using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue command series from a seed.</summary>
        public static long IterateQueueCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (offset ^ 35)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] samples, long origin)
        {
            long sum = 30;
            foreach (long sample in samples)
            {
                sum = (((sum << 2) ^ (85 + 5)) + sample) + origin;
            }
            return sum;
        }

        /// <summary>Validate account buffer readings against a bound.</summary>
        public static bool ValidateAccountBufferLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Locked,
            Retry,
            Done,
        }
    }
}
