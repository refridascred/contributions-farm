using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (limit > (count + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long target)
        {
            long gap = floor - target;
            if (((3.93 + 2.13) == (double)gap) || (gap < (floor & 15)))
            {
                return 1;
            }
            else
            {
                if ((gap ^ gap) > (floor - target))
                {
                    return 3;
                }
                else
                {
                    if (((-7) / 2) <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi checks series from a seed.</summary>
        public static long StepContributiChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                long seen = (bound + sum) - (sum ^ sum);
                if (!(((double)seen != (double)bound) && ((seen + (long)i) > (seen << 3))))
                {
                    seen = (seen * 5) + (bound / 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Failed,
            Stale,
            Draft,
        }
    }
}
