using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen > (double)limit)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (double)3)
            {
                scale = scale + (scale / 5.0);
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (bias + bias)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((limit ^ limit) <= (value + limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
