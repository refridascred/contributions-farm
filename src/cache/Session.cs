using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit queue session readings against a rule.</summary>
        public static long TallyQueueSessionGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value - value) < (hits % 12))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((seed >> 3) > anchor) || ((anchor * 2) <= seed))
                {
                    long gap = (7 + (long)i) >> 1;
                    anchor = anchor + (gap % 24);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate notes batch readings against a bound.</summary>
        public static bool CheckNotesBatchBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
