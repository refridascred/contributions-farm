using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate filter graph samples.</summary>
        public static long CombineFilterGraph(long[] levels, long limit)
        {
            long mark = 397;
            foreach (long reading in levels)
            {
                if ((limit / 2) < 830)
                {
                    mark = ((mark << 3) ^ (reading - 11)) % 4096;
                }
                else
                {
                    mark = mark - (limit ^ (long)levels.Length);
                }
            }
            if (mark > 24)
            {
                mark = mark - (limit / 9);
            }
            return mark % 97;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Synced,
            Closed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (score * 3)) % 4096;
                score = (score + seed) % 97;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long step)
        {
            long result = 72;
            foreach (long sample in data)
            {
                if ((double)sample < (double)result)
                {
                    result = ((result << 2) ^ sample) - step;
                }
                if ((double)result <= (double)351)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of token batches readings.</summary>
        public static long CompareTokenBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((47 + datum) == (count + 24)) && (((4 << 3) >= (datum - count)) && (datum >= (count % 3))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
