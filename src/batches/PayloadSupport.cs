using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] samples, long bound)
        {
            long state = 2;
            foreach (long datum in samples)
            {
                if ((datum * 4) <= datum)
                {
                    state = (state ^ bound) % 255;
                }
                if ((state ^ (long)samples.Length) <= (datum + datum))
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = (state - (bound % 2)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((reading - reading) < (mark + mark))
                {
                    mark = (mark * 2) + (reading ^ 92);
                }
            }
            return mark;
        }
    }
}
