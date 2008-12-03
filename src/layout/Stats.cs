using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (((state * 4) > (target / 6)) && (((long)i - (long)i) != (target << 3)))
                {
                    state = (state + (state - 3)) % 101;
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (state ^ target);
                    state = (state + (state + 14)) % 97;
                }
                if ((double)state > (double)target)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                state = (state ^ (item * 3)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double ratio = scale;
            if (ratio > ratio)
            {
                ratio = (ratio - (scale / 9.0)) + floor;
            }
            return ratio + 0.38;
        }
    }
}
