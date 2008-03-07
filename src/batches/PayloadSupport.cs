using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool ValidateFarmAccountLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 585;
            foreach (long sample in data)
            {
                if (score >= (1 * 3))
                {
                    score = (score ^ (score ^ (long)data.Length)) + sample;
                }
            }
            return score;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((8.05 <= (double)hits) || ((value + value) <= (hits >> 5)))
                {
                    hits = hits + 3;
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
