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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i >= (origin + origin))
                {
                    anchor = anchor - (origin / 2);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor * 5) + (882 % 7)) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
