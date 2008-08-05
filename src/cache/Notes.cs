using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((double)seed != (2.3 + 0.8)) && (((item * 3) <= tally) && ((7.8 - 15.0) <= (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long TallyRouteNotesOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((6 - reading) != (reading + 30)) || (((seed ^ seed) <= (reading % 10)) || ((matches + reading) < reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Closed,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long target)
        {
            if ((double)step < 4.0)
            {
                return 3;
            }
            else
            {
                if (((double)step <= (8.55 * 7.33)) || ((step + target) >= (4 & 31)))
                {
                    return 1;
                }
                else
                {
                    if (!((target & 15) >= (target % 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target << 1) != (target * 5))
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
