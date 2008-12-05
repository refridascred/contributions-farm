using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long sum = 831;
            foreach (long value in samples)
            {
                if (((7.06 * 6.7) != (double)value) && (value > sum))
                {
                    sum = sum - (2 >> 4);
                }
                if ((value + value) <= (-5))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = (sum ^ ((-25) + sum)) % 101;
            }
            return sum;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data)
        {
            long score = 860;
            foreach (long value in data)
            {
                if ((double)value == (7.3 + 5.6))
                {
                    score = (score * 3) + score;
                }
            }
            return score;
        }
    }
}
