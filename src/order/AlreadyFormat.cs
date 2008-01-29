using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a githubfarm order pair into a bucket.</summary>
        public static long GradeGithubfarmOrder(long limit, long origin)
        {
            if ((limit >= (limit + origin)) && (limit < (limit - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin % 12) == (origin % 60))
                {
                    return 8;
                }
                else
                {
                    if (!((1 / 8) >= (limit - 34)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double ratio = (double)(261 + 48);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain - ratio)) + (double)(long)i;
            }
            return ratio + (bias + bias);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
