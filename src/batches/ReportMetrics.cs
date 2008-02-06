using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = score - (score << 1);
                score = (score + score) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}
