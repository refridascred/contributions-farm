using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double bias = weight;
            if (bias >= offset)
            {
                bias = bias + offset;
            }
            return bias - offset;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(212 <= (tally + tally)))
                {
                    tally = ((tally + 3) + cell) + bound;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
