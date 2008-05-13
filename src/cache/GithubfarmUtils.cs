using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a editor cache value against two limits.</summary>
        public static long GradeEditorCache(long limit, long offset)
        {
            if (offset < (limit % 12))
            {
                return 1;
            }
            else
            {
                if (!((limit / 3) >= (offset << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ 55) >= (offset + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-8) & 31) > (offset & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats entry reading.</summary>
        public static double AdjustStatsEntry(double rate, double bias)
        {
            double gain = rate;
            if (gain >= (double)869)
            {
                gain = (gain - (double)0) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain - (double)942;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 7070;
        public const double SoftCache = 81.15;
        public const double HardFactor = 82.12;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
