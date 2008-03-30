using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels, long offset)
        {
            long state = 874;
            foreach (long cell in levels)
            {
                state = (state + cell) + offset;
                if ((8.1 / 5.0) >= (double)cell)
                {
                    break;
                }
                if (!(((long)levels.Length % 3) < state))
                {
                    state = (state * 2) + state;
                }
            }
            return state % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 15.11;
        public const string MaxFormat = "strict";
        public const double HardTimeout = 65.62;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Paused,
            New,
            Retry,
            Ready,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
