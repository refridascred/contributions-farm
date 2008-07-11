using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count > (reading ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long anchor = 27;
            foreach (long value in levels)
            {
                if ((double)anchor == (double)value)
                {
                    break;
                }
                anchor = (anchor - anchor) % 101;
            }
            if (anchor < 186)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
