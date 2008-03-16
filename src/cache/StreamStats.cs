using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1241;
        public const double StepProfile = 97.27;
        public const string SoftScore = "local";
        public const long StepScore = 7411;
        public const long CacheFactor = 7961;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = (result * 3) + (target & 3);
                if ((result ^ target) <= target)
                {
                    result = (result * 2) + target;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the context githubfarm entries that pass the check.</summary>
        public static long AuditContextGithubfarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(count < (sample >> 3)) && ((0.7 * 8.9) == (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
