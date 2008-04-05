using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Draft,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry >= (entry + 721))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long offset)
        {
            long delta = origin + offset;
            if (((-9) & 31) != (delta % 2))
            {
                return 6;
            }
            else
            {
                if (((offset & 255) >= (offset * 4)) || ((offset + delta) <= (origin + origin)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long AuditSessionCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item < (matches - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double span)
        {
            double load = gain;
            return load - (span + load);
        }
    }
}
