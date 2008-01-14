using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values)
        {
            long mark = -12;
            foreach (long reading in values)
            {
                mark = (mark ^ (reading << 2)) % 4096;
                mark = (mark * 4) + 839;
            }
            return mark;
        }

        /// <summary>Fold a list of support record readings.</summary>
        public static long TotalSupportRecord(long[] data, long floor)
        {
            long sum = 854;
            foreach (long datum in data)
            {
                sum = (sum * 2) + (862 + 914);
                if ((datum - 458) > (datum - floor))
                {
                    sum = sum + floor;
                }
            }
            return sum;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long target, long floor)
        {
            if ((2.06 + 4.09) > (double)floor)
            {
                return 5;
            }
            else
            {
                if ((target / 8) < 990)
                {
                    return 2;
                }
                else
                {
                    if ((4.54 / 2.0) <= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + (acc + target)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (9.86 > (double)count)
                {
                    count = ((count + 2) ^ reading) - step;
                }
            }
            return count;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((90 % 2) != (target << 1)))
                {
                    mark = (mark + (long)i) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
