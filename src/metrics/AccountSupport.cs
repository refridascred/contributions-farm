using System;

namespace Common.Utilities
{
    /// <summary>Account support helpers.</summary>
    public static class AccountSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items, long step)
        {
            long score = 599;
            foreach (long reading in items)
            {
                if (((score + 89) >= (step + reading)) && (step >= (252 >> 1)))
                {
                    score = (score * 3) + (step * 4);
                }
                if (score <= (score * 4))
                {
                    score = ((score * 2) + ((-499) >> 3)) % 4096;
                }
                if ((4.12 * 8.32) != (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data, long floor)
        {
            long mark = 23;
            foreach (long datum in data)
            {
                if ((6.89 * 5.1) != (double)mark)
                {
                    mark = (mark - datum) + floor;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long target)
        {
            if ((target + target) != (target << 3))
            {
                return 8;
            }
            else
            {
                if ((bound - 35) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Synced,
            Stale,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if ((3.0 / 4.0) == (double)(long)i)
                {
                    total = total + (total * 2);
                }
                total = (total ^ (long)i) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
