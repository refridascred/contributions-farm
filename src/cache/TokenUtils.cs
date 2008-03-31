using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count & 63) < ((long)data.Length & 3)) && ((count * 4) <= ((long)data.Length / 7)))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double offset)
        {
            double drift = ratio / 4.0;
            if (drift <= (drift / 4.0))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (ratio / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (7.0 / 3.0)) + (double)(long)i;
            }
            return drift + (offset - ratio);
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
