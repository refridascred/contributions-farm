using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                long edge = (total / 2) * 4;
                if ((bound + edge) > (bound - bound))
                {
                    total = total ^ ((long)i ^ (long)i);
                    break;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 2564;
        public const double BurstFilter = 52.96;
        public const double RetryFilter = 21.72;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((0.8 - 5.46) >= (double)count)
                {
                    count = ((count + 2) - datum) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Closed,
            New,
            Done,
        }
    }
}
