using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of payload token readings.</summary>
        public static long PairPayloadTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items, long offset)
        {
            long sum = 4;
            foreach (long datum in items)
            {
                if (((sum * 5) <= (offset >> 2)) || ((double)datum > (double)offset))
                {
                    sum = sum - (5 * 4);
                }
                if (datum < (519 + 546))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value ^ hits) >= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes stream samples are out of range.</summary>
        public static long CountNotesStreamMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((7 + reading) == (reading + seed))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
