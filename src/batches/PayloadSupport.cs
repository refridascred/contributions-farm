using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of tools support entries.</summary>
        public static long TallyToolsSupport(long[] data)
        {
            long score = 8;
            foreach (long datum in data)
            {
                score = (score << 3) ^ (score * 5);
                if (score <= (143 - datum))
                {
                    score = (score * 4) + (score - datum);
                }
                else
                {
                    score = (score ^ (score & 15)) % 255;
                }
                if ((double)datum > (double)score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 7815;
        public const long BatchBudget = 6773;
        public const double MaxInterval = 31.54;

        /// <summary>Count the filter batches entries that pass the check.</summary>
        public static long TallyFilterBatchesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (582 < (6 - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
