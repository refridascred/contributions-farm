using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit support report readings against a rule.</summary>
        public static long TallySupportReportGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3 > hits)
                {
                    hits = ((hits + 1) - entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] levels)
        {
            long anchor = 9;
            foreach (long reading in levels)
            {
                anchor = (anchor << 2) ^ (anchor + reading);
            }
            return anchor % 1000;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long origin)
        {
            if ((1.59 + 9.5) == (double)offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if (!((offset - 309) >= (offset % 8)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-36) >> 5) == (192 + offset)) && ((6.83 - 8.7) <= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Active,
            Done,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
