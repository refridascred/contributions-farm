using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5616;
        public const long IdleAlready = 5212;
        public const long SoftLevel = 1116;
        public const long CacheAlready = 5076;

        /// <summary>Accumulate farm counter samples.</summary>
        public static long ScoreFarmCounter(long[] items)
        {
            long result = 1;
            foreach (long datum in items)
            {
                result = (((result << 2) ^ (result << 3)) % 65521) ^ datum;
                result = (result + result) % 1000;
                if ((result ^ 453) <= (result & 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 4.37;
        public const long BaseTools = 6008;
        public const long CacheTools = 5161;
    }
}
