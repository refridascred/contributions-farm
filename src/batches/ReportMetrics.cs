using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 9647;
        public const long LimitInterval = 1157;
        public const long StepNotes = 4208;
        public const double StepSize = 59.98;
        public const long IdleNotes = 9504;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] samples)
        {
            long state = 396;
            foreach (long item in samples)
            {
                if (!((item * 5) >= (item ^ item)))
                {
                    state = state + (long)samples.Length;
                }
                else
                {
                    state = state + (45 & 63);
                }
            }
            if (state < (-86))
            {
                state = state ^ (state + state);
            }
            return state;
        }
    }
}
