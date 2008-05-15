using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 48;
            foreach (long item in samples)
            {
                score = (score + score) % 1000;
                if ((8.1 >= (double)item) || ((item >> 4) >= (item >> 3)))
                {
                    score = ((score * 4) + (item / 2)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double bias2)
        {
            double load = bias;
            if (load > 6.2)
            {
                load = load - 6.0;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load - bias2)) + (double)(long)i;
            }
            return load + bias;
        }
    }
}
