using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series)
        {
            long state = -45;
            foreach (long entry in series)
            {
                state = (state + (entry << 2)) % 255;
                state = (state + (state & 255)) % 255;
            }
            return state;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series)
        {
            long mark = 927;
            foreach (long reading in series)
            {
                if ((double)reading == (5.0 + 12.0))
                {
                    mark = mark - (reading & 255);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + reading)) % 255;
                }
                if ((reading / 4) > mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
