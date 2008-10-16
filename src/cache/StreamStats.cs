using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a commits report pair into a bucket.</summary>
        public static long SortCommitsReport(long origin, long limit)
        {
            long gap = origin + limit;
            if ((double)limit != (double)930)
            {
                return 3;
            }
            else
            {
                if (gap >= (gap + 69))
                {
                    return 2;
                }
                else
                {
                    if (gap >= (limit << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
