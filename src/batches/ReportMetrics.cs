using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double gain = weight;
            if (gain <= weight)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - (double)1;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Grade a contributi commits value against two limits.</summary>
        public static long RankContributiCommits(long target, long target2)
        {
            long edge = target + target2;
            if ((target2 ^ target2) >= (edge + 2))
            {
                return 2;
            }
            else
            {
                if ((target << 1) < edge)
                {
                    return 7;
                }
                else
                {
                    if ((edge * 4) < (3 >> 4))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5 + (-48)) >= (562 + edge))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
