using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ (result + seed);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool VerifyGithubfarmCommandRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a metrics account sample.</summary>
        public static long FindMetricsAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
