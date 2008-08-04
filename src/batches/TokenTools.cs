using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length << 1) > (matches >> 1))
                {
                    matches = ((matches + 3) + datum) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double weight = (double)(10 + 85);
            if (weight <= (double)84)
            {
                weight = (weight + offset) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (offset - offset)) + (double)(long)i;
            }
            return weight - (double)53;
        }
    }
}
