using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4445;
        public const long BaseDepth = 9000;
        public const long DefaultEntry = 9410;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset / 8) >= 281)
                {
                    score = score - offset;
                    score = ((score << 2) ^ (score % 10)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count - count) == (36 << 3)) || ((count - 1) <= value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches <= (matches & 31))
                {
                    matches = ((matches + 2) ^ cell) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
