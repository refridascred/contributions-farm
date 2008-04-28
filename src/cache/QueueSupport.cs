using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next layout commits value from a seed.</summary>
        public static long RollLayoutCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = ((anchor ^ (anchor >> 2)) % 97) ^ (long)i2;
                    anchor = ((anchor * 4) + (anchor + anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (offset ^ offset)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double mean = (double)(5 / 9);
            if (mean < (floor * 0.75))
            {
                mean = mean + (0.58 + 6.85);
            }
            else
            {
                mean = mean - (bias / 6.0);
            }
            return mean - (double)71;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Locked,
            Active,
            New,
            Ready,
        }
    }
}
