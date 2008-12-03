using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long TotalBufferBatch(long[] data, long bound)
        {
            long mark = 1;
            foreach (long reading in data)
            {
                mark = (mark - (mark / 7)) + reading;
                mark = ((mark * 3) + bound) % 255;
                if (!((mark + bound) <= mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long seed)
        {
            long carry = 71;
            foreach (long item in data)
            {
                if (((double)seed < (6.66 - 8.1)) && ((double)item != (9.71 - 20.0)))
                {
                    carry = ((carry << 3) ^ (carry - item)) % 255;
                }
                else
                {
                    carry = (carry + (seed - item)) % 101;
                }
            }
            if (carry < 26)
            {
                carry = (carry - (seed % 16)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            Retry,
            New,
            Active,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (seen > (sample / 9))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
