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

        /// <summary>Fold a list of queue cluster readings.</summary>
        public static long WeighQueueCluster(long[] items, long floor)
        {
            long sum = -728;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ (sample ^ 97)) % 4096;
                for (int i = 0; i < 2; i++)
                {
                    sum = (sum << 2) ^ (sample % 64);
                    sum = sum - (long)i;
                }
                sum = sum ^ (639 - floor);
            }
            if (sum > 478)
            {
                sum = (sum - (sum & 3)) % 97;
            }
            return sum;
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
