using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 270;
        public const string BatchSpan = "open-edge";
        public const long SoftSpan = 3785;
        public const long StepDepth = 9653;
        public const double DefaultProfile = 64.8;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardInterval = 1771;
        public const long IdleWidth = 8147;
        public const long LimitGraph = 1355;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long mix = 819;
            foreach (long value in readings)
            {
                mix = mix - value;
                if ((value - value) != (mix + value))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate entry metrics readings against a bound.</summary>
        public static bool VerifyEntryMetricsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
