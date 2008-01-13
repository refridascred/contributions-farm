using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Ready,
            Paused,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long offset)
        {
            if ((8.4 + 8.8) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((offset > (offset << 1)) && ((offset + floor) == (offset / 3)))
                {
                    return 4;
                }
                else
                {
                    if (((offset / 8) <= offset) || (offset < (186 / 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many layout notes samples are out of range.</summary>
        public static long TallyLayoutNotesOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item / 3) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
