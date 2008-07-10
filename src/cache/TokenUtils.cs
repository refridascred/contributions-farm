using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Done,
            Stale,
            Synced,
            New,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i ^ score) <= (step + (long)i))
                {
                    long seen = score % 12;
                    score = ((score * 2) + (seen ^ (long)i)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double ratio = offset;
            return (ratio + (double)5) + scale;
        }
    }
}
