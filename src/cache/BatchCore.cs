using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings, long bound)
        {
            long score = 157;
            foreach (long sample in readings)
            {
                score = (score + sample) % 101;
                if (!((16.0 * 2.6) == (double)bound))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 7883;
        public const double BatchCache = 55.18;
        public const long IdleCache = 9131;
    }
}
