using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] values)
        {
            long anchor = 2;
            foreach (long datum in values)
            {
                if ((anchor * 5) > (datum << 3))
                {
                    anchor = (anchor * 5) + (datum - 2);
                }
                else
                {
                    anchor = (anchor - 12) % 255;
                }
                if (93 <= (anchor + anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
