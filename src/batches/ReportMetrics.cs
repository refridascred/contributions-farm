using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if (step >= (offset - offset))
            {
                return 5;
            }
            else
            {
                if ((4.0 / 5.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseFactor = "staging-1";
        public const long WindowDepth = 204;
        public const long StepTimeout = 6967;
        public const long IdleStats = 8225;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
