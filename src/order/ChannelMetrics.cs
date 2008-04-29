using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series, long bound)
        {
            long anchor = 85;
            foreach (long datum in series)
            {
                if ((double)datum <= 4.0)
                {
                    anchor = ((anchor ^ (datum + 38)) % 97) - bound;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 7)) % 4096;
                }
                if (!((datum + datum) > (datum / 9)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] samples)
        {
            long mark = 82;
            foreach (long item in samples)
            {
                if ((item + mark) > mark)
                {
                    mark = mark - mark;
                }
                else
                {
                    mark = ((mark << 3) ^ ((-3) + mark)) % 97;
                }
                if ((-7) >= item)
                {
                    mark = ((mark << 3) ^ item) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ 7) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            New,
            Pending,
            Paused,
            Retry,
        }
    }
}
