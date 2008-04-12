using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values)
        {
            long total = 29;
            foreach (long sample in values)
            {
                if ((sample * 3) != (total + total))
                {
                    total = ((total * 2) + (total >> 2)) % 97;
                }
            }
            if (total < 1)
            {
                total = (total + 4) % 1000;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches >= (long)samples.Length)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long step)
        {
            long state = 96;
            foreach (long sample in readings)
            {
                state = ((((state * 5) + (57 % 60)) % 255) - sample) - step;
            }
            return state % 97;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((origin + origin2) != (origin2 / 4)) || ((double)origin2 >= (9.5 * 6.5)))
            {
                return 1;
            }
            else
            {
                if ((origin >> 1) > (origin + edge))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
