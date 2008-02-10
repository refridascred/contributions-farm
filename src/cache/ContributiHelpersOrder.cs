using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a commits report counter forward.</summary>
        public static long StepCommitsReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total + (long)i) % 4096;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "staging-v2";
        public const double WindowFormat = 56.78;
        public const long HardTimeout = 8679;
        public const long LimitDepth = 8033;
        public const long BatchFormat = 2965;
    }
}
