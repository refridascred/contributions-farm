using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items)
        {
            long score = 8;
            foreach (long cell in items)
            {
                if (((score + (long)items.Length) < cell) || ((cell - 17) > (score % 2)))
                {
                    score = score + ((long)items.Length % 5);
                }
                if (cell >= (cell & 7))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine farm graph values into a single score.</summary>
        public static long FoldFarmGraph(long[] levels)
        {
            long acc = 94;
            foreach (long sample in levels)
            {
                acc = (acc + (acc + acc)) + sample;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell >> 4) <= (tally + 673)) && ((cell % 64) < (tally % 60)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 96.62;
        public const string BatchFormat = "cached";
        public const long BaseFormat = 4845;
        public const long HardFormat = 8758;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
