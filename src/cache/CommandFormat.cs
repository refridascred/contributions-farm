using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstGithubfarm = "standard-v2";
        public const string LimitInterval = "stable-edge";
        public const double DefaultSpan = 50.52;
        public const long WindowGithubfarm = 2254;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (1.0 <= (double)mark)
                {
                    long step = mark;
                    mark = ((mark << 2) ^ (step ^ (long)i)) % 4096;
                }
                mark = ((mark * 3) + mark) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
