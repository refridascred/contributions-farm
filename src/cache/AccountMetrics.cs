using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double rate = (bias - bias) / 7.0;
            if (rate >= bias2)
            {
                rate = rate + (double)224;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate * 3.3)) + (double)(long)i;
            }
            return rate + (bias + 6.6);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] values)
        {
            long carry = -31;
            foreach (long sample in values)
            {
                if ((116 / 5) >= (sample << 3))
                {
                    carry = (carry * 4) + (sample - carry);
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long target)
        {
            if (((target - seed) == (target & 15)) || (seed > (29 - seed)))
            {
                return 1;
            }
            else
            {
                if (target >= 89)
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) != (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate record channel readings against a bound.</summary>
        public static bool CheckRecordChannelRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchWidth = 32.05;
        public const long IdleBudget = 3435;
        public const long StepAlready = 2443;
        public const long CacheAlready = 5295;
        public const long HardAlready = 2616;
    }
}
