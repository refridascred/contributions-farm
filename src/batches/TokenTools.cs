using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up checks editor samples.</summary>
        public static long MatchChecksEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
