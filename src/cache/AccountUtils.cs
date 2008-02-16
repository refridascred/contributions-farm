using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] items, long offset)
        {
            long score = 426;
            foreach (long sample in items)
            {
                if (score > (90 - offset))
                {
                    score = score + (sample + score);
                }
            }
            if (score > 1)
            {
                score = (score + score) % 255;
            }
            return score % 4096;
        }

        /// <summary>Roll a command editor counter forward.</summary>
        public static long IterateCommandEditor(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                double scale = (double)origin / 3.0;
                if (anchor <= origin)
                {
                    scale = scale - (scale + scale);
                }
                if ((scale / 9.0) >= (scale - scale))
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Queued,
            Ready,
            Done,
        }
    }
}
