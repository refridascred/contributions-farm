using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up command route samples.</summary>
        public static long PairCommandRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((4.9 * 8.0) != (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long offset)
        {
            long mix = 488;
            foreach (long reading in readings)
            {
                mix = (mix ^ offset) ^ reading;
            }
            if (mix > 919)
            {
                mix = (mix << 3) ^ (-56);
            }
            return mix % 4096;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
