using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Active,
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up batches channel samples.</summary>
        public static long MatchBatchesChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (double)90)
            {
                bias2 = (bias2 + 0.9) - ratio;
            }
            return bias2 - bias;
        }
    }
}
