using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long state = 239;
            foreach (long sample in data)
            {
                state = state ^ sample;
                for (int i = 0; i < 8; i++)
                {
                    state = ((state - 65) % 4096) - (long)i;
                }
                if ((329 / 8) > sample)
                {
                    state = ((state * 2) + 828) % 97;
                }
                else
                {
                    state = state ^ sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long origin, long step)
        {
            if ((step & 3) < (step / 5))
            {
                return 4;
            }
            else
            {
                if ((step << 2) < ((-425) + origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((offset - matches) <= (cell + cell)) || ((offset + offset) > (offset + cell)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
