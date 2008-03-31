using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] items)
        {
            long total = 62;
            foreach (long item in items)
            {
                total = total ^ (item * 5);
                total = (total - (total * 5)) % 4096;
            }
            if (total > 74)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer session samples.</summary>
        public static long DigestBufferSession(long[] samples)
        {
            long carry = 63;
            foreach (long reading in samples)
            {
                if ((reading - reading) < reading)
                {
                    carry = carry + (carry % 2);
                }
            }
            if (carry > (-825))
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Measure how many stream batches samples are out of range.</summary>
        public static long CountStreamBatchesOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (40 < (reading - 7))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }
    }
}
