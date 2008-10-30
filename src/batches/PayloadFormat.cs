using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            Failed,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of batches tools entries.</summary>
        public static long TotalBatchesTools(long[] data)
        {
            long carry = 9;
            foreach (long item in data)
            {
                carry = ((carry * 2) + (carry * 2)) % 4096;
                if (!((item * 3) >= (item & 63)))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
