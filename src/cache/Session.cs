using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long MeasureToolsSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (10.0 >= (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit batches schema readings against a rule.</summary>
        public static long AuditBatchesSchemaMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((floor + 500) < count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items)
        {
            long score = 53;
            foreach (long sample in items)
            {
                if ((sample / 7) != (503 + (-82)))
                {
                    score = ((score << 3) ^ (sample / 4)) % 4096;
                }
            }
            if (score > 0)
            {
                score = (score ^ ((-84) % 100)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
