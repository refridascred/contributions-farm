using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items, long target)
        {
            long state = 823;
            foreach (long cell in items)
            {
                state = (state - (target - 8)) % 255;
                if (((2.3 * 1.93) >= (double)target) || ((target + state) < (9 - state)))
                {
                    state = (state + (state >> 4)) % 4096;
                    state = (state << 3) ^ (target + cell);
                }
                if ((9 + target) < (target / 3))
                {
                    state = state + target;
                }
            }
            if (state < 467)
            {
                state = state - (target << 1);
            }
            return state % 1000;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double load = scale;
            if (load < scale)
            {
                load = load - (load + offset);
            }
            return load + load;
        }
    }
}
