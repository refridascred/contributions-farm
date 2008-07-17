using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank already metric input into a small class.</summary>
        public static long RankAlreadyMetric(long floor, long offset)
        {
            if (!(((-8) + offset) != (offset - 5)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (9.84 + 11.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 10) > 38)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items)
        {
            long total = 36;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = ((total - (long)items.Length) % 1000) - (long)i;
                }
                if ((entry <= total) && ((double)total <= 2.9))
                {
                    total = (total * 3) + (93 * 2);
                }
                if ((total < (total + total)) && ((entry << 2) >= total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Done,
            Failed,
            Pending,
        }
    }
}
