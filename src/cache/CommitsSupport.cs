using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long MeasureFilterChannelHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) <= (50 + tally))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Match up account metrics samples.</summary>
        public static long PairAccountMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseScore = 2525;
        public const long WindowTimeout = 1121;
        public const string BaseCount = "latest-edge";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
