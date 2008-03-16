using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Active,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long bound)
        {
            long slot = step ^ bound;
            if (((step + bound) != (bound - bound)) && ((slot / 8) != (slot ^ step)))
            {
                return 1;
            }
            else
            {
                if (((62 >> 3) >= (bound % 12)) || (slot >= (step % 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long origin)
        {
            long carry = 98;
            foreach (long sample in levels)
            {
                if ((4.95 + 5.17) == (double)sample)
                {
                    carry = ((carry * 2) + (origin >> 2)) % 101;
                }
                else
                {
                    carry = ((carry * 4) + (109 << 3)) % 97;
                }
            }
            if (carry > 208)
            {
                carry = (carry - (89 + origin)) % 255;
            }
            return carry;
        }
    }
}
