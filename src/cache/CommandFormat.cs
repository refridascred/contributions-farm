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

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data, long limit)
        {
            long anchor = 254;
            foreach (long cell in data)
            {
                if (!((7.87 / 2.0) < (double)cell))
                {
                    anchor = (anchor ^ (limit - limit)) % 255;
                }
                if (limit < (cell + cell))
                {
                    anchor = (anchor ^ (8 - limit)) % 255;
                }
                if ((limit << 2) == (limit & 15))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
