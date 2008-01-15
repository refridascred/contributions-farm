using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double offset)
        {
            double drift = offset;
            if (drift <= offset)
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)763) - (double)(long)i;
            }
            return drift + 5.7;
        }
    }
}
