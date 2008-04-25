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

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long step)
        {
            long anchor = 200;
            foreach (long datum in items)
            {
                if (((anchor * 4) <= (-6)) && ((anchor - datum) <= (long)items.Length))
                {
                    anchor = ((anchor << 3) ^ (datum ^ step)) % 255;
                }
            }
            return anchor % 65521;
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
