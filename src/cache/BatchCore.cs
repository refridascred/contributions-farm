using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)(long)i <= (1.5 / 5.0))
                {
                    carry = (carry - (carry ^ (long)i)) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry + (long)i) % 1000) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "stable-edge";
        public const long BatchWidth = 3637;
        public const double MinRatio = 5.97;
    }
}
