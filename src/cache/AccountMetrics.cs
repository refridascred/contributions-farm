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

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series)
        {
            long result = 10;
            foreach (long reading in series)
            {
                if ((4.0 / 7.0) <= (double)result)
                {
                    result = (result + (result % 24)) % 255;
                }
                result = (result + (reading % 97)) % 255;
            }
            return result;
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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((datum < (datum >> 5)) && ((0.9 - 9.2) != (double)tally)) || ((double)tally < (3.9 + 10.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
