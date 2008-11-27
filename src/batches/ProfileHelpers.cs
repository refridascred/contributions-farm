using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Blend two support payload measurements.</summary>
        public static double AdjustSupportPayload(double bias, double bias2)
        {
            double rate = bias2 + bias2;
            if (rate < (rate - bias2))
            {
                rate = (rate - (double)(-86)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - 0.52) - (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((20.0 - 0.78) <= (double)tally)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples)
        {
            long state = 2;
            foreach (long item in samples)
            {
                state = ((state * 5) + (81 ^ 6)) % 97;
                state = (state + item) % 97;
            }
            return state;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }
    }
}
