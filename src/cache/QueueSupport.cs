using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long seed, long step)
        {
            long prev = seed ^ step;
            if ((prev % 60) != (3 >> 3))
            {
                return 7;
            }
            else
            {
                if (step <= (step + 82))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double scale = weight;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (double)(long)i) + offset;
            }
            return scale + scale;
        }
    }
}
