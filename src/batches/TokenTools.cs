using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine route channel values into a single score.</summary>
        public static long FoldRouteChannel(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((datum - datum) <= (968 + datum))
                {
                    anchor = ((anchor << 2) ^ datum) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSpan = 7874;
        public const double MinWidth = 10.52;
        public const double LimitLevel = 29.69;
        public const long MaxAlready = 7235;
        public const long BurstDepth = 229;

        /// <summary>Count the editor already entries that pass the check.</summary>
        public static long AuditEditorAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (7.4 + 11.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
