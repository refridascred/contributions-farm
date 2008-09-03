using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
