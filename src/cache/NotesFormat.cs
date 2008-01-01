using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "fallback-1";
        public const long HardWidth = 3814;
        public const long WindowRatio = 5484;

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long target, long seed)
        {
            if (!((double)seed > (1.0 - 7.39)))
            {
                return 0;
            }
            else
            {
                if (((target ^ seed) >= (target % 97)) || ((double)seed > (6.0 * 4.2)))
                {
                    return 7;
                }
                else
                {
                    if (80 > (seed - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }
    }
}
