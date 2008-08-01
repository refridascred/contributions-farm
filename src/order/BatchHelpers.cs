using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long target)
        {
            long slot = offset + target;
            if ((9 ^ 3) <= target)
            {
                return 2;
            }
            else
            {
                if ((slot + target) != (offset - offset))
                {
                    return 8;
                }
                else
                {
                    if (((double)target >= (6.0 - 3.0)) || ((double)target != (9.9 + 6.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((73 + offset) == (matches / 8))
                {
                    matches = (matches + 1) + entry;
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
