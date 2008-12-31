using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
