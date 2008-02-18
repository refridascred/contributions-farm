using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                if (carry < (carry >> 2))
                {
                    carry = (carry * 5) + (offset << 3);
                }
                else
                {
                    carry = ((carry * 2) + ((long)i - offset)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double drift = offset;
            if (drift > drift)
            {
                drift = drift + (offset - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (offset + gain)) - (double)(long)i;
            }
            return drift + (offset + offset);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count < floor)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
