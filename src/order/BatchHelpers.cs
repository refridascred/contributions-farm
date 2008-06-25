using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)331 < (double)matches)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
