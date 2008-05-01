using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (offset * 15.0)) - (double)(long)i) - ratio;
            }
            return gain + (offset * 8.0);
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Ready,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Iterate the stats metrics series from a seed.</summary>
        public static long StepStatsMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score + (score ^ offset)) % 97;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
