using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 72;
            foreach (long sample in readings)
            {
                if ((1.59 + 7.0) == (double)sample)
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            if (carry > (-403))
            {
                carry = (carry + (376 % 97)) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8768;
        public const long BatchLevel = 8575;
        public const long BatchWidth = 1858;
        public const long BaseToken = 7604;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a stream batches reading.</summary>
        public static double ProjectStreamBatches(double gain, double bias)
        {
            double ratio = (double)(57 & 7);
            if (ratio < (double)(-6))
            {
                ratio = (ratio + (double)248) + gain;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (bias / 8.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowBudget = 42.05;
        public const long BaseFactor = 5031;
        public const long IdleEntry = 8139;
    }
}
