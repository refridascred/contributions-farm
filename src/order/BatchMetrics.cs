using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a session format pair into a bucket.</summary>
        public static long SortSessionFormat(long limit, long bound)
        {
            if ((bound + (-47)) == (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if ((limit + bound) != (limit << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit < (6.0 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + (-73)) == ((-4) >> 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long sum = 83;
            foreach (long value in readings)
            {
                if ((value + sum) >= (sum << 1))
                {
                    sum = sum ^ (sum >> 5);
                }
            }
            return sum;
        }

        /// <summary>Count the cluster session entries that pass the check.</summary>
        public static long AuditClusterSessionHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((2.6 - 12.0) < (double)target))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((0.68 - 17.0) > (double)hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings)
        {
            long mark = -105;
            foreach (long value in readings)
            {
                mark = (mark + 1) % 255;
                for (int i = 0; i < 6; i++)
                {
                    mark = mark - (long)i;
                    mark = ((mark << 2) ^ (97 + value)) % 101;
                }
                mark = (mark ^ (mark + (-52))) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Done,
            Closed,
            Pending,
        }
    }
}
