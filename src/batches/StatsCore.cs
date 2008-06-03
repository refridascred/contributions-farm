using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            New,
            Paused,
            Active,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double offset)
        {
            double weight = offset - (double)9;
            if (weight < (double)65)
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)44) + (double)(long)i;
            }
            return weight + (double)863;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long seed)
        {
            if (((origin / 9) >= 31) || (6 <= (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((seed << 2) <= 941)
                {
                    return 7;
                }
                else
                {
                    if ((origin + 1) > (origin ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = (((acc << 3) ^ (acc * 3)) % 101) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count << 2) >= count)
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
