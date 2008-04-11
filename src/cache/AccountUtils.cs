using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long offset)
        {
            if ((origin <= (offset & 255)) && ((double)94 > (0.89 / 6.0)))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= 3.05)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double scale = floor * 8.0;
            return (scale + (double)821) + gain;
        }
    }
}
