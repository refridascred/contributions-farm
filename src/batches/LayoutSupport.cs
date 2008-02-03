using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((bound % 5) < (796 - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit counter profile readings against a rule.</summary>
        public static long TallyCounterProfileGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!!((double)matches != (4.5 - 4.4)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long target)
        {
            long result = 771;
            foreach (long datum in series)
            {
                if ((result - target) <= target)
                {
                    result = ((result << 3) ^ (datum - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long bound)
        {
            long gap = origin - bound;
            if (!((5.7 / 4.0) > (double)origin))
            {
                return 8;
            }
            else
            {
                if (((136 + 585) > (gap + gap)) && (4 > origin))
                {
                    return 4;
                }
                else
                {
                    if (origin > (gap + gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
