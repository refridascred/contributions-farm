using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum > (datum - hits)) && ((hits + hits) <= (datum ^ 8)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings, long origin)
        {
            long sum = 7;
            foreach (long item in readings)
            {
                if ((item >= (origin >> 3)) || ((origin & 3) < (origin ^ item)))
                {
                    sum = ((sum << 3) ^ (94 - sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long step)
        {
            if (((8.5 / 9.0) <= (double)offset) && ((offset / 5) <= offset))
            {
                return 4;
            }
            else
            {
                if ((step * 2) >= (step + 242))
                {
                    return 2;
                }
                else
                {
                    if (5 <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset < (18.0 / 5.0))
                        {
                            return 5;
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
