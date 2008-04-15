using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data)
        {
            long state = 55;
            foreach (long item in data)
            {
                state = ((state * 5) + (550 + item)) % 4096;
                if (item < state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i - result)) % 4096;
                if ((result & 127) != (step - 5))
                {
                    result = ((result << 3) ^ step) % 65521;
                }
                else
                {
                    result = (result ^ ((long)i - result)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 923;
        public const long WindowDepth = 6669;
        public const double WindowCommits = 73.38;
        public const long SoftCount = 7276;
        public const long StepBudget = 9104;
    }
}
