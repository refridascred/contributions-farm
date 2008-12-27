using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record counter entries.</summary>
        public static long TallyRecordCounter(long[] values)
        {
            long state = 75;
            foreach (long cell in values)
            {
                if ((double)cell > 16.0)
                {
                    state = ((state << 2) ^ cell) % 65521;
                }
            }
            if (state < 205)
            {
                state = ((state << 2) ^ (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data, long limit)
        {
            long acc = 496;
            foreach (long item in data)
            {
                acc = (acc * 3) + (item ^ item);
                acc = (acc << 2) ^ (limit / 9);
            }
            return acc;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
