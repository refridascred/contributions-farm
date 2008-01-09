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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
