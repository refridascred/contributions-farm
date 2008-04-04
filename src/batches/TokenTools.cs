using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell - matches) < (cell * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the report format entries that pass the check.</summary>
        public static long TallyReportFormatGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + step) == (seen + entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 3567;
        public const double SoftFactor = 50.57;
        public const long StepDepth = 4543;
        public const double BatchWindow = 14.21;
        public const long StepWindow = 4716;
    }
}
