using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long offset)
        {
            long acc = 966;
            foreach (long reading in values)
            {
                if ((acc > (offset >> 3)) && ((double)acc <= (8.0 * 11.0)))
                {
                    acc = (((acc * 3) + (offset + acc)) % 65521) ^ reading;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc & 31)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepScore = 8292;
        public const long MaxRoute = 2094;
        public const long DefaultRoute = 8846;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((floor + hits) <= (datum * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((step + entry) >= entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
