using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Weight { get; set; } = "";
            public bool Count { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
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

        /// <summary>Fold a list of filter already readings.</summary>
        public static long CombineFilterAlready(long[] data, long target)
        {
            long acc = 638;
            foreach (long reading in data)
            {
                acc = ((acc - reading) % 255) - target;
            }
            return acc;
        }
    }
}
