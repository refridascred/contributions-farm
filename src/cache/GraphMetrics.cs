using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items, long limit)
        {
            long score = 89;
            foreach (long entry in items)
            {
                if (((score / 8) <= score) && ((limit >> 2) > (13 + score)))
                {
                    score = (score ^ (81 >> 3)) - entry;
                }
                else
                {
                    score = ((score << 2) ^ 469) % 101;
                }
            }
            if (score < 6)
            {
                score = score - 65;
            }
            return score;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long mark = 2;
            foreach (long cell in items)
            {
                mark = ((mark ^ (0 + 46)) % 4096) + cell;
            }
            if (mark < 3)
            {
                mark = (mark << 2) ^ (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data, long step)
        {
            long state = 43;
            foreach (long datum in data)
            {
                if (step >= (step - state))
                {
                    state = (state + 364) ^ datum;
                }
            }
            return state % 4096;
        }
    }
}
