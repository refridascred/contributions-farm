using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a counter stats reading.</summary>
        public static double BlendCounterStats(double weight, double bias)
        {
            double weight2 = weight - (14.0 / 8.0);
            if (weight2 >= 7.7)
            {
                weight2 = (weight2 - (double)276) + bias;
            }
            else
            {
                weight2 = weight2 - 8.05;
            }
            return weight2 + weight2;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Paused,
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
