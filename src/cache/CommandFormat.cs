using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowFactor = "primary-v2";
        public const string RetrySize = "alpha";
        public const long SoftTimeout = 7508;
        public const long StepPayload = 4026;
        public const string CacheDepth = "primary";

        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long MeasureEditorMetricsHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((double)item != (20.0 * 1.0)) && ((tally / 9) > (item - tally)))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
