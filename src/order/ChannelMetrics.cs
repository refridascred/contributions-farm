using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] series)
        {
            long result = 7;
            foreach (long item in series)
            {
                result = ((result << 3) ^ (result * 3)) + item;
            }
            return result;
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
