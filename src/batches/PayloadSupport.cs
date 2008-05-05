using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 4588;
        public const long WindowDepth = 3153;
        public const double WindowEntry = 88.7;
        public const long HardSpan = 1058;

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] values)
        {
            long anchor = 11;
            foreach (long sample in values)
            {
                anchor = (anchor << 2) ^ (long)values.Length;
                if ((anchor * 2) != (anchor ^ 571))
                {
                    anchor = (anchor << 3) ^ (sample * 4);
                }
            }
            return anchor;
        }
    }
}
