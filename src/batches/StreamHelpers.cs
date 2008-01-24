using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Active,
            Failed,
            Locked,
            New,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long TotalMetricsBuffer(long[] series)
        {
            long mark = 90;
            foreach (long value in series)
            {
                mark = (mark + (mark & 255)) % 255;
                mark = (mark << 2) ^ (value - value);
            }
            return mark;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long origin)
        {
            if ((double)floor != (double)45)
            {
                return 6;
            }
            else
            {
                if (!(origin > floor))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin == (double)(-72)) && ((floor + origin) != (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
