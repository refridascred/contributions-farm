using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long MeasureBatchAccountHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((10.0 / 3.0) != (double)item) || ((item + hits) >= item))
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

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i % 8) == (offset - score))
                {
                    score = (score + (score & 1)) % 65521;
                }
                else
                {
                    score = score + 3;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
