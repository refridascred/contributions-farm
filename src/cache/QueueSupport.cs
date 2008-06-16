using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell * 2) > (matches << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
