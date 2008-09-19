using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Paused,
            Idle,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items)
        {
            long result = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 99) == (1 - result))
                {
                    result = (result * 3) + (result + datum);
                }
            }
            if (result < 1)
            {
                result = (result + (52 & 1)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((seen + sample) >= sample) || ((double)seen > (5.9 + 1.7)))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
