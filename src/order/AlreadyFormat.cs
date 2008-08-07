using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of batch stream readings.</summary>
        public static long MatchBatchStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ (result ^ offset);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Active,
            New,
            Queued,
            Closed,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 2) + score;
                score = (score << 3) ^ 63;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((origin - origin) <= (prev * 4))
            {
                return 7;
            }
            else
            {
                if ((bound / 5) < bound)
                {
                    return 3;
                }
                else
                {
                    if ((3.2 - 10.0) < (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
