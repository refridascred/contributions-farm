using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < (matches ^ cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long origin)
        {
            long state = 90;
            foreach (long datum in data)
            {
                if (((origin + datum) <= (datum - datum)) && ((datum << 3) >= origin))
                {
                    state = state + state;
                }
                if ((double)origin != (2.83 - 5.9))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
