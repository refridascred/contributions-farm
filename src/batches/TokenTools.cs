using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long total = 6;
            foreach (long datum in series)
            {
                total = (total + floor) - datum;
            }
            if (total > 6)
            {
                total = total - (total << 1);
            }
            return total;
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long MeasureSchemaToolsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen - 2) == (entry + (-53))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
