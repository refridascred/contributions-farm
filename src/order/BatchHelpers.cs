using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long floor2)
        {
            long bound = floor + floor2;
            if (753 < bound)
            {
                return 0;
            }
            else
            {
                if (((bound % 12) <= 4) && (326 >= floor))
                {
                    return 6;
                }
                else
                {
                    if (((floor % 97) > (floor2 << 1)) && (floor > floor2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.9 * 15.0) == (double)floor)
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
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total * 5) + (target + (long)i)) - (long)i2;
                }
                total = (total + ((long)i & 7)) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long TotalQueueContributi(long[] data)
        {
            long sum = 457;
            foreach (long datum in data)
            {
                if (!(sum < (datum - 318)))
                {
                    sum = (sum * 4) + (sum + datum);
                }
                if (((sum << 3) >= (595 - sum)) || ((sum & 63) < (12 << 2)))
                {
                    sum = ((sum * 3) + sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum * 4)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }
    }
}
