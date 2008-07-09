using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((tally / 5) < (tally + datum)) || ((double)9 > (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
