using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit graph tools readings against a rule.</summary>
        public static long AuditGraphToolsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((double)tally != (3.0 + 5.6)) && (reading > (floor + floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (target > (14 / 6))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample % 7) <= (count << 1)) || (count > (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((((value + tally) <= value) || ((value & 127) >= (tally << 1))) || ((-82) <= (value / 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
