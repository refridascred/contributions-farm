using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up metrics notes samples.</summary>
        public static long PairMetricsNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Idle,
            Synced,
            Ready,
        }
    }
}
