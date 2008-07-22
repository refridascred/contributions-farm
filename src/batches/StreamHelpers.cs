using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a editor stream counter forward.</summary>
        public static long SeriesEditorStream(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total + ((long)i << 1);
                if (165 < (total & 3))
                {
                    total = (total + (target - target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Locked,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(cell >= (cell - cell)))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of filter commits readings.</summary>
        public static long MatchFilterCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((tally << 3) <= cell) && ((cell >> 3) != (75 ^ (-66)))) || !((floor << 2) == (3 ^ floor)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
