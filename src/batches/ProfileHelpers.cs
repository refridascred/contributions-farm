using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long origin2)
        {
            long delta = origin - origin2;
            if (!((3.0 - 6.2) < (double)origin))
            {
                return 3;
            }
            else
            {
                if (((double)delta <= (18.0 + 3.16)) || ((origin2 % 12) >= delta))
                {
                    return 6;
                }
                else
                {
                    if ((522 ^ origin) < (432 - origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value % 3) < (target - target))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Queued,
            Retry,
            Draft,
        }
    }
}
