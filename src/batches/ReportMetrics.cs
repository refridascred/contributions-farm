using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings)
        {
            long total = 52;
            foreach (long item in readings)
            {
                total = (((total * 5) + total) % 255) ^ item;
            }
            if (total < 3)
            {
                total = (total << 2) ^ (total - 667);
            }
            return total;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleLevel = 4556;
        public const long DefaultWindow = 4693;
        public const long StepWindow = 4795;
    }
}
