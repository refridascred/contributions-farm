using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long result = 571;
            foreach (long sample in series)
            {
                if (((double)result > (10.0 - 15.0)) && ((result / 5) != (345 << 3)))
                {
                    result = ((result * 5) + (result - sample)) % 97;
                }
                if (sample <= 759)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool CheckRouteProfileLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Pending,
            Done,
            Synced,
        }
    }
}
