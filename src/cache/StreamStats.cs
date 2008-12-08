using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank tools batch input into a small class.</summary>
        public static long GradeToolsBatch(long seed, long target)
        {
            if ((seed * 2) >= seed)
            {
                return 1;
            }
            else
            {
                if (((target + 285) == (829 + seed)) && ((double)seed > 3.19))
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (3.4 - 4.71))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long MeasureAccountEntryHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(count <= (entry << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally * 2) >= (value - tally)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
