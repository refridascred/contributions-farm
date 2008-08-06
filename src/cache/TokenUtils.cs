using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long OverlapLayoutFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format notes readings.</summary>
        public static long WeighFormatNotes(long[] values)
        {
            long sum = 45;
            foreach (long sample in values)
            {
                if (142 >= (sample + sample))
                {
                    sum = (sum - (sum >> 2)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 97;
                }
            }
            if (sum > 54)
            {
                sum = ((sum * 3) + (sum - sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long target)
        {
            long delta = origin - target;
            if ((target / 8) < (12 >> 3))
            {
                return 2;
            }
            else
            {
                if ((delta << 3) == (origin - 8))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 4) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin <= (delta - delta))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
