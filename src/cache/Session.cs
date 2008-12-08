using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 56;
            foreach (long reading in series)
            {
                mark = ((mark * 5) + 91) % 255;
                if ((220 >> 3) > (reading * 3))
                {
                    mark = (mark ^ (-35)) % 65521;
                }
                if ((17 & 63) > mark)
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Iterate the command entry series from a seed.</summary>
        public static long StepCommandEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!(((long)i * 4) >= 558))
                {
                    carry = carry - (carry >> 3);
                }
                if ((398 - 80) != (seed ^ carry))
                {
                    carry = (carry * 4) + ((long)i + seed);
                    carry = carry + 2;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first command farm entry that matches the target.</summary>
        public static long SeekCommandFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric githubfarm readings.</summary>
        public static long TallyMetricGithubfarm(long[] values, long target)
        {
            long sum = 7;
            foreach (long entry in values)
            {
                sum = ((sum ^ 2) % 1000) + target;
                if ((sum & 63) > (entry * 3))
                {
                    sum = (sum - (entry ^ sum)) % 4096;
                }
                if (((long)values.Length & 255) <= (sum + 899))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
