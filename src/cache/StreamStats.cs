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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches > bound)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
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
