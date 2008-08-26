using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long offset, long step)
        {
            long cur = offset + step;
            if ((double)offset == (8.4 - 3.5))
            {
                return 1;
            }
            else
            {
                if ((offset & 255) <= (659 % 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (8.1 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((122 + cur) <= (offset & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count context metrics pairs that satisfy a relation.</summary>
        public static long CompareContextMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Pending,
            Closed,
            Ready,
        }
    }
}
