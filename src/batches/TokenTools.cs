using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long TallyToolsBatchesOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((seed / 9) < (seed + seed)) || (seed < (entry + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long MeasureSessionToolsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)matches != (2.3 + 10.0)) || (5.84 < (double)offset))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell >= target) && ((cell + count) < (count + target))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
