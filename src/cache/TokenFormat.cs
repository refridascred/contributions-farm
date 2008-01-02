using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((-501) % 24) < matches)
                {
                    matches = ((matches + 3) + value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format editor readings.</summary>
        public static long TotalFormatEditor(long[] readings)
        {
            long acc = -859;
            foreach (long reading in readings)
            {
                if (914 <= (acc / 5))
                {
                    acc = ((acc * 4) + (acc - acc)) + reading;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 255;
                }
            }
            if (acc < 2)
            {
                acc = (acc * 4) + (acc >> 2);
            }
            return acc;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 + cell) <= (count / 8))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
