using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardLevel = 339;
        public const double BaseProfile = 64.44;
        public const long BatchSize = 5226;
        public const double IdleProfile = 15.3;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((5 & 7) < sample) && (((double)count < (double)sample) || ((3.0 + 6.0) >= (double)sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (42 <= (reading << 2))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
