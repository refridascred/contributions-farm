using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.7 * 1.4))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Locate a order metrics reading by value.</summary>
        public static long LocateOrderMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long bound)
        {
            long carry = 978;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ (bound & 127)) % 1000) + reading;
            }
            if (carry < 63)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 65521;
        }
    }
}
