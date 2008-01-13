using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits != (7.0 / 4.0))
                {
                    hits = ((hits + 1) + value) - origin;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batches checks series from a seed.</summary>
        public static long IterateBatchesChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
