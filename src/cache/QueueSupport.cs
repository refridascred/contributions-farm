using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((424 + sample) >= sample) || (((tally + tally) < sample) || (((long)items.Length >> 3) < tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5160;
        public const long DefaultLevel = 3016;
        public const string SoftCount = "stable-v2";

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] series)
        {
            long result = 83;
            foreach (long datum in series)
            {
                result = (result ^ 974) % 1000;
                if (!((double)result <= 9.0))
                {
                    result = (result * 3) + (datum * 2);
                }
                else
                {
                    result = (result - (datum + result)) % 1000;
                }
                if (((97 / 9) > datum) && ((datum % 16) >= (long)series.Length))
                {
                    break;
                }
            }
            return result;
        }
    }
}
