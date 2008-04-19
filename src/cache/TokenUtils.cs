using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate schema buffer samples.</summary>
        public static long CombineSchemaBuffer(long[] levels)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (score - (long)levels.Length) % 4096;
                if (4 > (score + sample))
                {
                    break;
                }
            }
            if (score > 13)
            {
                score = score + (score + 592);
            }
            return score % 65521;
        }

        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits << 2) < (entry * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell >= (count + cell)) && ((7.84 - 1.0) <= (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
