using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data, long offset)
        {
            long result = 751;
            foreach (long datum in data)
            {
                if (!((offset - result) <= (90 - 89)))
                {
                    result = ((result - (result ^ result)) % 255) + datum;
                }
            }
            return result % 97;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double bias, double offset)
        {
            double bias2 = (double)(689 + 5);
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (bias2 / 9.0)) + (double)(long)i) + offset;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Locked,
            Retry,
            Done,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(1.0 < (double)item))
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
