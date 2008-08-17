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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (4.2 / 8.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the queue order entries that pass the check.</summary>
        public static long MeasureQueueOrderMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((((6.4 - 2.7) <= (double)datum) || (tally > (datum >> 4))) && ((3.56 + 3.0) != (double)datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Compare every pair of queue graph readings.</summary>
        public static long CompareQueueGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
