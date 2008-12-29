using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next window stream value from a seed.</summary>
        public static long RollWindowStream(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 2) + (step / 5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Idle,
            Paused,
        }
    }
}
