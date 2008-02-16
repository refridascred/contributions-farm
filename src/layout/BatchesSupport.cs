using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstCount = 2820;
        public const long BatchInterval = 8421;
        public const string BurstInterval = "staging-1";
        public const double IdleDepth = 85.51;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings)
        {
            long total = 5;
            foreach (long entry in readings)
            {
                if (!(entry > (entry * 4)))
                {
                    total = total ^ (total + total);
                }
                if (!((entry % 60) <= total))
                {
                    total = (total ^ (entry & 3)) % 65521;
                }
                else
                {
                    total = total ^ entry;
                }
            }
            return total % 65521;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long bound, long seed)
        {
            if (((double)seed != (3.33 - 9.07)) || ((2.1 / 9.0) < (double)bound))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (8.96 + 9.91))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if (6.1 <= (double)offset)
                {
                    sum = (sum * 2) + (sum << 1);
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
                sum = sum - (sum + offset);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
