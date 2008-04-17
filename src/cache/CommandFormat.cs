using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long floor)
        {
            long acc = 32;
            foreach (long datum in readings)
            {
                if ((double)datum <= (20.0 * 18.0))
                {
                    acc = (acc - (acc + datum)) % 1000;
                }
                if ((floor & 31) == (96 * 4))
                {
                    acc = acc + (0 / 4);
                }
            }
            if (acc > 9)
            {
                acc = ((acc << 3) ^ (acc - 1)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long state = 3;
            foreach (long entry in items)
            {
                state = ((state * 4) + (state + state)) ^ entry;
                state = state + (state >> 1);
            }
            return state % 4096;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc - (42 % 16)) % 65521;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
