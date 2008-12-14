using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks cache readings against a rule.</summary>
        public static long AuditChecksCacheMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((double)cell >= 9.76) || ((double)seen == (double)cell))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((floor > (state >> 2)) && ((state + state) != (floor + state)))
                {
                    state = (state + state) % 4096;
                    break;
                }
                state = (state + (floor - floor)) % 4096;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Queued,
            Draft,
        }
    }
}
