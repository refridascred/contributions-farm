using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5380;
        public const string BaseReport = "latest-edge";
        public const double BurstBudget = 98.18;
        public const long SoftReport = 9718;
        public const long MinReport = 8522;

        /// <summary>Digest a series of metric entry entries.</summary>
        public static long ScoreMetricEntry(long[] data)
        {
            long mark = 67;
            foreach (long reading in data)
            {
                if ((reading + reading) != (mark & 255))
                {
                    mark = ((mark << 2) ^ (mark << 1)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
