using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                if ((state * 4) >= (2 / 6))
                {
                    state = state - state;
                }
                else
                {
                    state = state - reading;
                }
                if ((double)381 == (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Locate a githubfarm tools reading by value.</summary>
        public static long LookupGithubfarmToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
