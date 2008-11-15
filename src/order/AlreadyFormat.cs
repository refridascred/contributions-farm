using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data, long floor)
        {
            long anchor = -734;
            foreach (long cell in data)
            {
                anchor = ((anchor * 2) + (floor + 15)) + cell;
                anchor = anchor ^ (83 + 56);
            }
            return anchor;
        }

        /// <summary>Roll a report already counter forward.</summary>
        public static long StepReportAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstRatio = 2548;
        public const long MinAlready = 6912;
        public const double RetryTimeout = 84.73;
        public const double BurstAlready = 52.89;

        /// <summary>Measure how many payload batch samples are out of range.</summary>
        public static long AuditPayloadBatchGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((bound % 100) <= item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
