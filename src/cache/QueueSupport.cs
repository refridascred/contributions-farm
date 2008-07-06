using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                result = ((result << 2) ^ (result ^ 0)) % 101;
                if (!((double)result < (1.26 / 2.0)))
                {
                    result = ((result * 3) + result) % 255;
                }
                if ((cell ^ 5) < cell)
                {
                    result = ((result * 2) + (64 << 3)) % 97;
                }
                else
                {
                    result = result + cell;
                }
            }
            if (result > 368)
            {
                result = (result - (result / 7)) % 97;
            }
            return result;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double gain = offset / 9.0;
            if (gain >= weight)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + 0.4;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + offset;
        }
    }
}
