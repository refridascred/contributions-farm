using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            New,
            Active,
            Failed,
            Ready,
        }

        /// <summary>Count report support pairs that satisfy a relation.</summary>
        public static long PairReportSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
