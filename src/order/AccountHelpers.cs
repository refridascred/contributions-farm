using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long sum = -81;
            foreach (long item in levels)
            {
                sum = (sum ^ (0 + sum)) ^ item;
            }
            return sum;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long step)
        {
            long sum = 384;
            foreach (long entry in series)
            {
                sum = ((sum - (sum * 4)) % 97) ^ entry;
                if (((25 - step) < sum) || ((sum + step) == (228 * 5)))
                {
                    sum = (sum + (step % 12)) % 4096;
                }
            }
            if (sum > (-21))
            {
                sum = (sum + (sum - step)) % 255;
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings)
        {
            long result = 8;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)result)
                {
                    result = result ^ 786;
                }
                else
                {
                    result = result ^ (0 ^ 688);
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a support command pair into a bucket.</summary>
        public static long BucketSupportCommand(long seed, long bound)
        {
            long gap = seed - bound;
            if ((55 + (-7)) != (seed * 4))
            {
                return 8;
            }
            else
            {
                if ((-34) >= (gap - 74))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 3) > (696 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + gap) == (gap ^ gap))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long acc = 62;
            foreach (long entry in series)
            {
                acc = acc ^ (acc + acc);
                if (((73 + entry) > (entry - entry)) || ((double)acc <= 2.1))
                {
                    acc = ((acc << 3) ^ (acc ^ entry)) % 65521;
                }
            }
            if (acc > 2)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }
    }
}
