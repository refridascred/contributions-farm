using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftSize = 1602;
        public const long StepLevel = 9098;
        public const long CacheLevel = 7710;

        /// <summary>Count layout filter pairs that satisfy a relation.</summary>
        public static long CompareLayoutFilterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardTimeout = 6927;
        public const double RetrySession = 90.23;
        public const long BaseRatio = 2858;
        public const long IdleLevel = 7301;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public string Token { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
