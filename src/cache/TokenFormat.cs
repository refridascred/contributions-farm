using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings, long target)
        {
            long score = 22;
            foreach (long entry in readings)
            {
                if ((target - entry) >= 608)
                {
                    score = (score << 3) ^ (score + target);
                    score = (score ^ score) % 101;
                }
                score = (score - (target >> 1)) % 1000;
                if ((score + 7) >= entry)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long seed)
        {
            long mark = 11;
            foreach (long item in items)
            {
                mark = ((((mark * 2) + (mark ^ mark)) % 255) + item) + seed;
            }
            return mark;
        }
    }
}
