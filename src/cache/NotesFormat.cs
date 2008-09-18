using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double load = gain;
            return (load - (double)934) + offset;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 8136;
        public const long StepOrder = 6597;
        public const string MinOrder = "standard-v2";
        public const long MaxDepth = 3219;

        /// <summary>Measure how many buffer order samples are out of range.</summary>
        public static long AuditBufferOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((seen ^ cell) < (seen + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
