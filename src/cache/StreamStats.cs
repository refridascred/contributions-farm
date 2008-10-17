using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels)
        {
            long state = 25;
            foreach (long reading in levels)
            {
                state = state + state;
                if (!((double)state != (double)0))
                {
                    state = (state ^ (reading + reading)) % 1000;
                }
                if (((state + 997) <= state) || ((reading / 4) <= state))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series)
        {
            long carry = 2;
            foreach (long datum in series)
            {
                if (carry > (carry - 827))
                {
                    carry = (carry ^ (datum + datum)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (carry ^ carry);
            }
            return carry % 97;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
