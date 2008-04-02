using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series, long target)
        {
            long mark = 84;
            foreach (long value in series)
            {
                mark = ((mark << 2) ^ (mark - value)) + target;
            }
            return mark % 4096;
        }

        /// <summary>Compare every pair of payload queue readings.</summary>
        public static long MatchPayloadQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long floor)
        {
            long score = 649;
            foreach (long sample in items)
            {
                if (!(5.0 < (double)score))
                {
                    score = ((score << 3) ^ floor) + sample;
                }
            }
            if (score < 262)
            {
                score = score ^ (score - score);
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 233;
        public const double MinRoute = 17.98;
        public const long RetryBudget = 8178;
        public const string BatchRoute = "open-1";
        public const long HardInterval = 163;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((-37) > (cell / 2))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }
    }
}
