using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 6177;
        public const long DefaultSchema = 2593;
        public const long MaxSchema = 9615;
        public const double BurstTimeout = 19.3;
        public const long WindowBudget = 5101;

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long limit, long offset)
        {
            if ((limit >> 1) != (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((5.19 + 7.28) == (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((double)2 < (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the queue batches entries that pass the check.</summary>
        public static long CountQueueBatchesMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((18 % 8) <= (bound + 666)) && ((double)datum < (9.84 + 8.65))) || ((double)count == (10.0 - 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count contributi report pairs that satisfy a relation.</summary>
        public static long PairContributiReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
