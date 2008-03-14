using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of format batches readings.</summary>
        public static long PairFormatBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double offset)
        {
            double scale = offset;
            if (scale <= 8.0)
            {
                scale = (scale - (double)72) - bias;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((9.94 / 9.0) < (double)bound)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Mode { get; set; }
        }
    }
}
