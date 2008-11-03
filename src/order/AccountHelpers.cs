using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (bound << 3)) % 65521;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the report record entries that pass the check.</summary>
        public static long MeasureReportRecordMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed - (long)levels.Length) <= (matches % 12))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum - datum) > datum) && ((matches - datum) <= datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest-v2";
        public const long DefaultSpan = 4652;
        public const string WindowScore = "alpha-v2";
        public const string RetryInterval = "local";
        public const double BaseRatio = 17.6;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7736;
        public const long DefaultWidth = 963;
        public const long MaxRecord = 2685;
        public const long CacheBudget = 9086;
        public const long SoftRecord = 398;
    }
}
