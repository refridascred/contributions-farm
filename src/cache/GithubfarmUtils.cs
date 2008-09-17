using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double offset)
        {
            double load = 16.0 / 8.0;
            if (load <= load)
            {
                load = (load + (offset * 4.0)) - bias;
            }
            return load + offset;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data, long offset)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                anchor = anchor ^ entry;
            }
            if (anchor < 80)
            {
                anchor = anchor - (anchor + offset);
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleWidth = 6894;
        public const double MaxRecord = 54.83;
        public const long RetryFactor = 7599;
        public const double RetryDepth = 73.55;
        public const long MaxInterval = 1321;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 12.27;
        public const double RetryBudget = 5.24;
        public const long DefaultFactor = 920;
    }
}
