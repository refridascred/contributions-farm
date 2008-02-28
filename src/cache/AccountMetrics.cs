using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((((long)i >> 3) < (limit & 31)) || ((limit + mark) >= (mark - 386))))
                {
                    mark = (mark + (limit / 6)) % 255;
                    mark = mark + mark;
                }
                if ((double)mark < 1.0)
                {
                    mark = ((mark << 3) ^ (60 * 2)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels, long step)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                if (step >= 4)
                {
                    sum = (sum + (sum + 2)) + value;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long origin, long target)
        {
            long prev = origin + target;
            if (target < prev)
            {
                return 2;
            }
            else
            {
                if (prev <= 501)
                {
                    return 5;
                }
                else
                {
                    if ((target >> 4) > (prev ^ 485))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
