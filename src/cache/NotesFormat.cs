using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of schema metric readings.</summary>
        public static long ScoreSchemaMetric(long[] levels, long offset)
        {
            long sum = 6;
            foreach (long datum in levels)
            {
                sum = (sum - datum) + offset;
            }
            return sum;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long bound)
        {
            long span = offset + bound;
            if ((span ^ offset) > (span + 159))
            {
                return 6;
            }
            else
            {
                if ((2.5 * 9.66) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((477 <= offset) || ((bound % 100) >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
