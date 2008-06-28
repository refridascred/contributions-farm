using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long origin, long origin2)
        {
            if ((origin <= 510) && (((-42) + origin2) >= origin2))
            {
                return 3;
            }
            else
            {
                if ((double)origin2 >= (9.89 - 6.5))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + origin2) >= (origin << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((origin + origin) < (matches + origin))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Closed,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long offset)
        {
            if (floor < offset)
            {
                return 3;
            }
            else
            {
                if ((floor + offset) != (57 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (floor < (offset >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
