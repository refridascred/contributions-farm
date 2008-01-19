using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
