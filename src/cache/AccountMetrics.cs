using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first metrics report entry that matches the target.</summary>
        public static long LookupMetricsReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the checks channel series from a seed.</summary>
        public static long DeriveChecksChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + (long)i;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((2.2 / 3.0) <= (double)datum) && ((double)(long)items.Length >= (9.9 / 8.0)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin + offset;
            if ((offset < (offset % 97)) || (949 > origin))
            {
                return 1;
            }
            else
            {
                if (next < (9 - next))
                {
                    return 8;
                }
                else
                {
                    if ((origin - 9) != (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - origin) <= (next + 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
