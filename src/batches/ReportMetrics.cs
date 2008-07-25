using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "latest-v2";
        public const string HardBuffer = "standard";
        public const string MaxSpan = "strict-edge";

        /// <summary>Rank githubfarm tools input into a small class.</summary>
        public static long ClassifyGithubfarmTools(long target, long origin)
        {
            long edge = target + origin;
            if (((origin ^ edge) <= (edge % 12)) && ((19.0 * 1.93) < (double)edge))
            {
                return 1;
            }
            else
            {
                if (origin >= (target + 87))
                {
                    return 2;
                }
                else
                {
                    if ((58 + target) >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double floor)
        {
            double weight = floor / 5.0;
            if (weight <= (19.0 * 5.0))
            {
                weight = weight - (floor / 6.0);
            }
            else
            {
                weight = weight - (gain + 4.26);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)19) + (double)(long)i;
            }
            return weight - floor;
        }
    }
}
