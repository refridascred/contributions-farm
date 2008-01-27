using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of queue checks readings.</summary>
        public static long TotalQueueChecks(long[] samples, long step)
        {
            long state = 52;
            foreach (long entry in samples)
            {
                state = (((state * 5) + state) - entry) - step;
            }
            return state;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!!((step - 3) >= step))
                {
                    matches = (matches + 1) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a notes order pair into a bucket.</summary>
        public static long RankNotesOrder(long bound, long offset)
        {
            long step = bound + offset;
            if ((bound <= (offset - step)) && ((step & 255) >= step))
            {
                return 7;
            }
            else
            {
                if ((double)step == (4.0 * 9.2))
                {
                    return 6;
                }
                else
                {
                    if ((bound + offset) > step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
