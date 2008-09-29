using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                long step = score;
                score = score ^ (score + score);
                if (((double)step <= (3.0 / 3.0)) && (((-2) % 5) < ((long)i ^ step)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (offset >= (0 + 37))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 93.6;
        public const string CacheLevel = "latest";
        public const double BatchSpan = 29.9;
    }
}
