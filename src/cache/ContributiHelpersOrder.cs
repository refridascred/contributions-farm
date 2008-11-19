using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitDepth = 8365;
        public const double LimitReport = 31.02;
        public const long MaxLevel = 5219;

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values)
        {
            long mix = 26;
            foreach (long reading in values)
            {
                if ((0 + reading) == (5 - 7))
                {
                    mix = ((mix * 2) + (7 / 4)) % 97;
                }
                if ((89 + mix) < mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value < (value / 3))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
