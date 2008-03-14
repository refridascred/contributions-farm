using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((bound & 1) >= (seen + 0))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= (ratio + 12.0))
            {
                ratio = (ratio + (double)3) + offset;
            }
            else
            {
                ratio = ratio - 7.92;
            }
            return ratio + 0.73;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseSize = "latest-edge";
        public const long BurstQueue = 6769;
        public const long BurstInterval = 4046;
    }
}
