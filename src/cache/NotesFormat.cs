using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Done,
        }
    }
}
