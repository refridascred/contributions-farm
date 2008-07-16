using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double ratio = bias;
            if (ratio <= bias)
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio + ratio;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long target)
        {
            if ((19 * 2) < (target % 16))
            {
                return 6;
            }
            else
            {
                if ((target / 9) != (4 >> 2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double span)
        {
            double gain2 = (gain / 6.0) - (double)355;
            if (gain2 > (8.4 * 9.0))
            {
                gain2 = gain2 - (double)679;
            }
            else
            {
                gain2 = gain2 + (span - span);
            }
            return gain2 - (gain2 + 4.82);
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double ratio = 18.0;
            if (ratio >= (ratio - 18.0))
            {
                ratio = ((ratio - ratio) - scale) + offset;
            }
            return ratio + 14.0;
        }
    }
}
