using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxCount = 95.7;
        public const double BatchFactor = 50.66;
        public const long BaseTimeout = 9410;
        public const long StepNotes = 4434;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total << 3);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
