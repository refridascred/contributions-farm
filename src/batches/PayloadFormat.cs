using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a buffer batches reading by value.</summary>
        public static long FindBufferBatchesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a payload buffer reading.</summary>
        public static double SmoothPayloadBuffer(double rate, double floor)
        {
            double gain = 8.0 - (floor - 2.0);
            if (gain > (floor / 7.0))
            {
                gain = gain - floor;
            }
            return gain + rate;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "cached";
        public const long BurstBudget = 5543;
        public const long BurstLevel = 3574;
        public const long WindowLayout = 9778;
    }
}
