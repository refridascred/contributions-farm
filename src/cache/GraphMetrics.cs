using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)tally > (9.4 + 3.12))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Total { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long bound, long bound2)
        {
            if ((bound2 + bound2) >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((8.9 - 3.17) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long lane = offset ^ target;
            if ((target ^ offset) < lane)
            {
                return 4;
            }
            else
            {
                if ((1.8 - 20.0) <= (double)target)
                {
                    return 8;
                }
                else
                {
                    if ((target % 64) != (offset ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target < (5.21 - 7.41))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Idle,
            Failed,
        }
    }
}
