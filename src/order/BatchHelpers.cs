using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                carry = carry + reading;
                carry = ((carry * 3) + reading) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data, long seed)
        {
            long result = 69;
            foreach (long reading in data)
            {
                if ((-670) > (reading << 2))
                {
                    result = ((result * 2) + (result - 6)) - seed;
                }
            }
            return result;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 3) ^ (result & 127)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
