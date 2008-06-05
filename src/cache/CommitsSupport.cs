using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long origin2)
        {
            if (!(origin < (origin2 + origin2)))
            {
                return 0;
            }
            else
            {
                if ((double)origin2 < (2.0 / 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((6.5 + 4.6) <= (double)origin2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings)
        {
            long mix = 415;
            foreach (long item in readings)
            {
                mix = ((mix << 2) ^ mix) - item;
            }
            return mix % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (1.0 / 5.0))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double load = (weight + weight) / 9.0;
            if (load >= floor)
            {
                load = load + 19.0;
            }
            else
            {
                load = load + 4.1;
            }
            return load + (weight + load);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseScore = 9029;
        public const long BatchNotes = 9247;
        public const string RetrySize = "legacy-edge";
    }
}
