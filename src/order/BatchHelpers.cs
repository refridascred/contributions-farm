using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine command cluster values into a single score.</summary>
        public static long TotalCommandCluster(long[] samples)
        {
            long carry = -6;
            foreach (long reading in samples)
            {
                carry = ((carry + (carry & 1)) % 97) ^ reading;
                carry = (carry - (carry + 201)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            New,
            Failed,
            Done,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
