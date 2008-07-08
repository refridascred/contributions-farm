using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit cluster cache readings against a rule.</summary>
        public static long CountClusterCacheGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((-73) + step) >= step)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
