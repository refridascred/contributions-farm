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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
