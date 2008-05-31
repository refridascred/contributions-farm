using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next report support value from a seed.</summary>
        public static long IterateReportSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = (acc ^ acc) - cell;
            }
            return acc;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long mark = 750;
            foreach (long datum in readings)
            {
                if ((mark * 3) == (mark + mark))
                {
                    mark = ((mark << 3) ^ datum) % 97;
                    mark = (mark << 3) ^ mark;
                }
                mark = ((mark << 3) ^ (datum ^ mark)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Audit token contributi readings against a rule.</summary>
        public static long CountTokenContributiOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((floor - floor) != (matches - datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
