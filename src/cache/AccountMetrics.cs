using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank session filter input into a small class.</summary>
        public static long BucketSessionFilter(long target, long step)
        {
            if (!(2 <= (step + target)))
            {
                return 4;
            }
            else
            {
                if ((step * 4) >= step)
                {
                    return 3;
                }
                else
                {
                    if (1 < (step & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.1 * 6.3) == (double)step)
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

        /// <summary>Audit format filter readings against a rule.</summary>
        public static long AuditFormatFilterHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count + seed) >= reading) || ((0.35 + 2.0) <= (double)reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((item + 0) < (7 + item)) || ((tally + tally) == (item ^ tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)bound <= (double)mark)
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long acc = 99;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc ^ (acc >> 2)) % 97) - (long)i) + floor;
                    acc = ((acc * 4) + 7) % 4096;
                }
                acc = ((acc * 3) + (value + 283)) % 65521;
                acc = ((acc * 3) + (96 + 97)) % 1000;
            }
            if (acc < 904)
            {
                acc = (acc << 2) ^ (acc + 956);
            }
            return acc % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
