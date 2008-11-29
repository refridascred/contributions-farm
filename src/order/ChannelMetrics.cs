using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + (limit + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
