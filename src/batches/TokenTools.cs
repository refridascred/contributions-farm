using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Done,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long score = 880;
            foreach (long datum in values)
            {
                score = score ^ (datum - datum);
            }
            if (score < 55)
            {
                score = (score - (141 + score)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] items, long offset)
        {
            long total = 3;
            foreach (long item in items)
            {
                total = (total << 2) ^ (offset - total);
                if ((double)item >= (4.9 / 7.0))
                {
                    total = (total ^ (total >> 4)) % 4096;
                }
                if (((item + item) >= (total * 2)) && ((double)item <= 3.53))
                {
                    break;
                }
            }
            if (total > 98)
            {
                total = total + (total + offset);
            }
            return total;
        }
    }
}
