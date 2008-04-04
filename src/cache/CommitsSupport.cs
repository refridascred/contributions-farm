using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long score = 692;
            foreach (long datum in readings)
            {
                if ((score & 31) <= datum)
                {
                    score = ((score << 2) ^ datum) % 97;
                }
                else
                {
                    score = (score + (score - score)) % 101;
                }
                score = (score << 2) ^ ((long)readings.Length + datum);
            }
            return score % 1000;
        }

        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long AuditCommandAccountGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((4 - matches) <= target)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up metrics counter samples.</summary>
        public static long PairMetricsCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits << 2) == (hits % 16))
                {
                    hits = ((hits + 1) + value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + ((long)i & 1)) % 1000;
                result = (result ^ (result & 3)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Synced,
            Active,
            Done,
            Closed,
        }
    }
}
