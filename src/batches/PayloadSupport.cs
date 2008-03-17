using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next counter format value from a seed.</summary>
        public static long RollCounterFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor + (anchor * 3)) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine counter route values into a single score.</summary>
        public static long FoldCounterRoute(long[] series, long bound)
        {
            long anchor = 51;
            foreach (long item in series)
            {
                if (!!((anchor + bound) == (bound & 3)))
                {
                    anchor = anchor - (item >> 2);
                }
                anchor = anchor - anchor;
            }
            if (anchor < 889)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 3641;
        public const long BaseSpan = 7525;
        public const long WindowMetrics = 826;
        public const long StepBudget = 5782;
        public const string MinMetrics = "open-edge";
    }
}
