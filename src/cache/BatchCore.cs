using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double load = (bias - bias) / 6.0;
            if (load <= (bias2 / 2.0))
            {
                load = load - (bias * 1.74);
            }
            return load - (bias2 + load);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + hits) > (value % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 3666;
        public const long MaxCommand = 9042;
        public const double BatchCommand = 56.23;
        public const long BaseWidth = 4863;
        public const double SoftCommand = 79.92;
    }
}
