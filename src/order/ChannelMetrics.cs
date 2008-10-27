using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Synced,
            Stale,
            Locked,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (anchor > (anchor ^ sample))
                {
                    anchor = ((anchor * 2) + 6) - limit;
                }
                else
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long CountFarmSchemaMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((9 - entry) < matches) && ((matches << 1) > (6 + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
