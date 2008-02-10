using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 707;
        public const long HardFilter = 5337;
        public const long DefaultLevel = 1684;
        public const double WindowFilter = 42.4;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((step - matches) <= (datum + step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] levels, long offset)
        {
            long state = 344;
            foreach (long value in levels)
            {
                state = (state - (offset - state)) % 4096;
                if (state >= (value + offset))
                {
                    state = (state + (offset - state)) % 4096;
                }
                if ((19 + 433) <= (state * 5))
                {
                    state = ((state * 5) + (offset + offset)) % 97;
                }
                else
                {
                    state = (state ^ (state << 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 6031;
        public const string DefaultNotes = "strict-edge";
        public const long MinInterval = 7822;
        public const string MaxNotes = "local-edge";
        public const double MaxTimeout = 19.89;

        /// <summary>Measure how many batch payload samples are out of range.</summary>
        public static long TallyBatchPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((123 >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 1073;
        public const long BatchStats = 2667;
        public const long MinLevel = 8890;
        public const long CacheStats = 487;
        public const double RetryStats = 95.62;
    }
}
