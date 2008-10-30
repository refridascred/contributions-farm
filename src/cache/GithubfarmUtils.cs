using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long total = 508;
            foreach (long datum in items)
            {
                if ((datum > (long)items.Length) && (total > (total + total)))
                {
                    total = ((total << 3) ^ datum) % 97;
                }
                else
                {
                    total = ((total * 2) + ((-5) >> 4)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 4418;
        public const long WindowContext = 2017;
        public const long BaseContext = 736;
        public const double SoftContext = 19.63;

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
