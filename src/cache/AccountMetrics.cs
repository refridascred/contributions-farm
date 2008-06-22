using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the entry tools entries that pass the check.</summary>
        public static long MeasureEntryToolsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value >= tally)
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Draft,
            Ready,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
