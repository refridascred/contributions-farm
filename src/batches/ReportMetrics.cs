using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long state = 243;
            foreach (long cell in items)
            {
                state = (state ^ cell) % 97;
                if (cell > (state + 9))
                {
                    break;
                }
            }
            if (state > 42)
            {
                state = (state - state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Find the first cluster support entry that matches the target.</summary>
        public static long LookupClusterSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
