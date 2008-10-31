using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long offset)
        {
            long sum = -922;
            foreach (long item in items)
            {
                sum = ((sum + item) % 97) - offset;
            }
            if (sum < (-199))
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            if (origin > (origin * 4))
            {
                return 2;
            }
            else
            {
                if ((origin % 64) <= (limit - 65))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
