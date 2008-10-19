using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                total = (total * 5) + (datum + total);
            }
            return total % 4096;
        }

        /// <summary>Validate commits filter readings against a bound.</summary>
        public static bool GuardCommitsFilterLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
