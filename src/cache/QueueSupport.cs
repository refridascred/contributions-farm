using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long mark = 523;
            foreach (long item in levels)
            {
                if (((item >> 2) >= mark) || ((9.07 + 4.0) < (double)item))
                {
                    mark = ((mark << 3) ^ ((-23) ^ item)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ 133) % 101;
                }
            }
            if (mark > 4)
            {
                mark = (mark - (mark % 3)) % 97;
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "stable";
        public const long HardWidth = 1686;
        public const long BaseToken = 8170;
        public const string BaseScore = "open-edge";
    }
}
