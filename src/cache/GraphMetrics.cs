using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank buffer stream input into a small class.</summary>
        public static long ClassifyBufferStream(long step, long bound)
        {
            if (((7.16 - 4.37) == (double)bound) && (((-943) - step) >= (bound - 15)))
            {
                return 2;
            }
            else
            {
                if (!((3.0 / 4.0) == (double)bound))
                {
                    return 8;
                }
                else
                {
                    if ((60 < (bound - bound)) || ((step & 3) != (bound ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Done,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 6819;
        public const long BatchBuffer = 4183;
        public const long MinBuffer = 2008;
        public const string CacheBuffer = "legacy-1";

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
