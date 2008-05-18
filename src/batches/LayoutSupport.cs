using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum & 15) < (datum + hits)) && (origin > (6 >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long result = 371;
            foreach (long cell in samples)
            {
                result = ((result + (limit / 9)) % 97) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((7.4 - 3.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long limit)
        {
            long delta = seed - limit;
            if ((double)312 != (double)seed)
            {
                return 0;
            }
            else
            {
                if ((delta << 1) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((164 + delta) != (21 / 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (15.0 + 19.0))
                        {
                            return 1;
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
