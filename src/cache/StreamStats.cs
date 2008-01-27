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

        /// <summary>Compare every pair of session counter readings.</summary>
        public static long OverlapSessionCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
