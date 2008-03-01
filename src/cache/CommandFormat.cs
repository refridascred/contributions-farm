using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long bound)
        {
            if ((bound - bound) == (seed * 5))
            {
                return 2;
            }
            else
            {
                if (!((double)bound < (18.0 - 17.0)))
                {
                    return 8;
                }
                else
                {
                    if ((bound + 744) <= (seed << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the contributi checks series from a seed.</summary>
        public static long StepContributiChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                long seen = (bound + sum) - (sum ^ sum);
                if (!(((double)seen != (double)bound) && ((seen + (long)i) > (seen << 3))))
                {
                    seen = (seen * 5) + (bound / 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of batch queue readings.</summary>
        public static long FoldBatchQueue(long[] levels)
        {
            long carry = 24;
            foreach (long item in levels)
            {
                if (((carry << 3) < carry) && ((long)levels.Length != (carry >> 2)))
                {
                    carry = ((carry - (84 << 2)) % 97) ^ item;
                }
            }
            return carry;
        }
    }
}
