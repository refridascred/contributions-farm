using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            Pending,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double ratio, double floor)
        {
            double drift = ratio;
            if (drift > floor)
            {
                drift = drift - ratio;
            }
            return drift + (floor - floor);
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double span)
        {
            double mean = span;
            if (mean < span)
            {
                mean = (mean - (span / 9.0)) - rate;
            }
            else
            {
                mean = mean - (double)839;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean * 20.0)) - (double)(long)i;
            }
            return mean + mean;
        }
    }
}
