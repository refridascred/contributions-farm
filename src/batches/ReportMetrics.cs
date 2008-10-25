using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long seed, long bound)
        {
            if ((seed & 3) > (seed + seed))
            {
                return 3;
            }
            else
            {
                if ((seed + 166) > (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 2060;
        public const long HardRatio = 1698;
        public const long DefaultScore = 2514;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long mark = -79;
            foreach (long sample in samples)
            {
                if (!((double)mark < (9.1 * 5.0)))
                {
                    mark = ((mark << 2) ^ 389) % 1000;
                }
                if ((sample >= (mark ^ sample)) && ((98 % 97) < (mark >> 2)))
                {
                    mark = mark + (mark * 3);
                }
                else
                {
                    mark = mark + ((-2) ^ sample);
                }
            }
            return mark;
        }
    }
}
