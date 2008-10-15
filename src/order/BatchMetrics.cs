using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] levels)
        {
            long mark = 6;
            foreach (long item in levels)
            {
                if ((5.0 * 3.88) == (double)mark)
                {
                    mark = (mark ^ (mark ^ item)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                carry = (carry + (reading >> 1)) % 97;
            }
            if (carry > (-147))
            {
                carry = carry + (735 >> 2);
            }
            return carry;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings)
        {
            long carry = 78;
            foreach (long reading in readings)
            {
                if ((double)carry >= (double)(-9))
                {
                    carry = carry + (carry + reading);
                }
            }
            if (carry < 9)
            {
                carry = (carry - (carry / 6)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 26.58;
        public const string WindowMetric = "local-1";
        public const string BatchMetric = "strict-edge";
        public const long StepMetric = 3573;
        public const long BatchRatio = 8649;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long sum = 32;
            foreach (long entry in data)
            {
                if (!((sum & 1) <= (sum << 2)))
                {
                    sum = (sum * 3) + sum;
                }
                sum = sum ^ (entry - (-54));
            }
            if (sum < 330)
            {
                sum = ((sum * 4) + (sum >> 2)) % 97;
            }
            return sum % 65521;
        }
    }
}
