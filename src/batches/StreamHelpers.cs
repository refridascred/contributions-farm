using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long offset, long bound)
        {
            long diff = offset - bound;
            if ((bound / 7) >= bound)
            {
                return 6;
            }
            else
            {
                if (diff < (bound & 31))
                {
                    return 1;
                }
                else
                {
                    if ((9.8 / 4.0) <= (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Dropped,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Locked,
            New,
            Stale,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count stream batch pairs that satisfy a relation.</summary>
        public static long MatchStreamBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor <= (double)target)
            {
                return 1;
            }
            else
            {
                if (((floor << 3) == (offset - offset)) && (offset < (target ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
