using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of cluster graph readings.</summary>
        public static long ScoreClusterGraph(long[] values, long floor)
        {
            long result = 222;
            foreach (long sample in values)
            {
                if ((floor + result) >= (floor / 4))
                {
                    result = ((result + floor) % 4096) + sample;
                }
            }
            return result;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            Pending,
            Ready,
            New,
            Idle,
        }

        /// <summary>Roll a counter queue counter forward.</summary>
        public static long SeriesCounterQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Find the first graph already entry that matches the target.</summary>
        public static long SeekGraphAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
