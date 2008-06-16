using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long step)
        {
            if (((step / 2) == (step << 2)) && (step >= (offset << 1)))
            {
                return 1;
            }
            else
            {
                if (((step - offset) > step) || ((double)37 == (double)offset))
                {
                    return 2;
                }
                else
                {
                    if ((10.0 * 5.0) >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((9.4 + 2.0) < (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
