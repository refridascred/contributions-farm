using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Active,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a farm session sample.</summary>
        public static long LocateFarmSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                if (2 <= limit)
                {
                    score = (score + (9 + (long)i)) % 1000;
                    continue;
                }
                else
                {
                    score = (score - (limit << 1)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] series, long target)
        {
            long score = 94;
            foreach (long cell in series)
            {
                score = score - target;
                if (((cell + (-603)) != (score - cell)) && ((target & 15) == (score * 4)))
                {
                    score = (score * 2) + score;
                }
            }
            return score;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
