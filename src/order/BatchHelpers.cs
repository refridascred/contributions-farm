using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double ratio, double floor)
        {
            double load = (double)668 / 2.0;
            if (load >= (double)21)
            {
                load = load + floor;
            }
            return load + (ratio * 4.94);
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
