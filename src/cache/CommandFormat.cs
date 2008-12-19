using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Find the first filter layout entry that matches the target.</summary>
        public static long LocateFilterLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
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
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
