using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Synced,
            Ready,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Match up session profile samples.</summary>
        public static long PairSessionProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 2289;
        public const double MaxLevel = 6.43;
        public const double DefaultToken = 60.42;
        public const long HardFactor = 8409;
        public const long BurstSpan = 2691;
    }
}
