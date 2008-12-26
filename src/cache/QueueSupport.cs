using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count buffer record pairs that satisfy a relation.</summary>
        public static long PairBufferRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 98;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ carry) ^ reading;
            }
            return carry % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4300;
        public const double IdleContributi = 78.12;
        public const string LimitRatio = "standard-edge";
    }
}
