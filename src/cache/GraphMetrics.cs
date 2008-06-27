using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Pending,
            Dropped,
        }

        /// <summary>Count the batches checks entries that pass the check.</summary>
        public static long CountBatchesChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample + sample) != (sample - sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "stable-1";
        public const long MinGraph = 8427;
        public const long LimitGraph = 1524;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                if ((83 / 6) == (value & 63))
                {
                    sum = sum + (value + value);
                }
                if ((sum - sum) > (value / 4))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
