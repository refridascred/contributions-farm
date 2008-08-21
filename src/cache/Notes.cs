using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a notes checks pair into a bucket.</summary>
        public static long SortNotesChecks(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((bound * 3) > origin)
            {
                return 0;
            }
            else
            {
                if (2.0 <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((7.83 + 1.5) != (double)origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)(-2) != (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long target2)
        {
            long gap = target - target2;
            if ((6.3 - 7.39) <= (double)target)
            {
                return 8;
            }
            else
            {
                if (((double)gap > (0.86 / 8.0)) || (gap < (target2 * 4)))
                {
                    return 3;
                }
                else
                {
                    if (!((target2 & 127) <= (9 & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (target <= gap)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long offset, long step)
        {
            if ((6.78 + 5.96) > (double)step)
            {
                return 1;
            }
            else
            {
                if (((double)step != (double)60) && ((step + offset) < (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
