using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            New,
            Queued,
            Paused,
        }

        /// <summary>Validate graph editor readings against a bound.</summary>
        public static bool VerifyGraphEditorLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account batch values into a single score.</summary>
        public static long DigestAccountBatch(long[] samples, long limit)
        {
            long state = 795;
            foreach (long datum in samples)
            {
                state = ((state * 5) + limit) % 4096;
                state = ((state << 2) ^ (datum + datum)) % 1000;
            }
            if (state > 294)
            {
                state = ((state << 3) ^ limit) % 255;
            }
            return state;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data, long limit)
        {
            long carry = 424;
            foreach (long reading in data)
            {
                carry = ((carry + 46) % 101) + reading;
                carry = (carry ^ (limit % 97)) % 97;
            }
            return carry;
        }
    }
}
