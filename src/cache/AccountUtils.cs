using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seen >= (item >> 4)) && (seen < (10 / 2))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum - count) != (datum + datum)) && ((2.65 * 5.04) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer command value from a seed.</summary>
        public static long DeriveBufferCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score >= (double)bound)
                {
                    score = score - (long)i;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
