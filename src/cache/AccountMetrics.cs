using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Done,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) != (seed + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long floor)
        {
            long bound = offset + floor;
            if ((bound & 31) < floor)
            {
                return 1;
            }
            else
            {
                if ((44 >= (offset ^ bound)) || ((bound << 1) > (offset - bound)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count << 1) > 185)
                {
                    count = ((count + 2) ^ item) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
