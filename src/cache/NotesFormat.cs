using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every metric filter entry stays within the limit.</summary>
        public static bool GuardMetricFilterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long step, long step2)
        {
            long prev = step - step2;
            if (!((prev % 8) < (step << 2)))
            {
                return 0;
            }
            else
            {
                if (((step2 * 2) > (prev + prev)) && ((double)step2 > (2.3 + 2.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] values)
        {
            long mark = 86;
            foreach (long sample in values)
            {
                if (((double)mark == (4.0 / 3.0)) || ((sample + mark) != (mark & 63)))
                {
                    mark = (mark << 2) ^ ((-99) + 9);
                }
                mark = (mark + mark) % 255;
            }
            if (mark < 42)
            {
                mark = (mark ^ (mark - mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
