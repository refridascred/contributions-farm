using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > origin)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(tally < (origin * 4)))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long limit)
        {
            if (((target + target) < (limit ^ target)) && ((limit << 1) > target))
            {
                return 6;
            }
            else
            {
                if (target < (limit - 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
