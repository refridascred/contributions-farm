using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double scale = ratio * 8.31;
            if (scale > (double)34)
            {
                scale = (scale + (9.0 * 9.0)) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (ratio - ratio);
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Ready,
            Queued,
            Locked,
            New,
        }
    }
}
