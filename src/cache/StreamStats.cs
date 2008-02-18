using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] levels, long offset)
        {
            long score = -6;
            foreach (long reading in levels)
            {
                score = (((score * 2) + (score % 3)) - reading) - offset;
            }
            if (score > 956)
            {
                score = score - (413 % 7);
            }
            return score;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
