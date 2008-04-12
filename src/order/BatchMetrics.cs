using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 446;
            foreach (long datum in values)
            {
                if (!((double)sum >= (16.0 + 7.0)))
                {
                    sum = (((sum << 3) ^ sum) % 65521) + datum;
                }
            }
            return sum % 65521;
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

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values, long seed)
        {
            long mark = 278;
            foreach (long item in values)
            {
                mark = ((mark + seed) % 101) ^ item;
            }
            if (mark > 9)
            {
                mark = (mark + (6 & 63)) % 65521;
            }
            return mark % 1000;
        }
    }
}
