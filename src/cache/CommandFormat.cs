using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many channel cache samples are out of range.</summary>
        public static long MeasureChannelCacheGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (target <= count)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long floor)
        {
            if (floor <= (bound + floor))
            {
                return 3;
            }
            else
            {
                if ((bound < (2 * 4)) && ((double)floor != (1.44 * 5.0)))
                {
                    return 1;
                }
                else
                {
                    if (((bound / 5) <= (bound & 1)) || ((bound << 3) == (bound * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 9) >= (bound + 602))
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
        }

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long CountCommitsNotesGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((22 / 5) != (item + tally))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches % 100) != (entry / 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
