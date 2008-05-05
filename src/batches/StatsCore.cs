using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(seen <= (item * 2)) || (((long)samples.Length + item) <= (seen ^ item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ (total ^ 60)) % 1000;
                if ((total ^ bound) <= (total / 6))
                {
                    total = total - total;
                    total = ((total * 3) + bound) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit filter checks readings against a rule.</summary>
        public static long TallyFilterChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((hits + hits) >= 764) && ((item - hits) != (6 + hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long bound, long origin)
        {
            if (((16.0 - 8.7) > (double)origin) && ((double)6 == (double)origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin < 9.0)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
