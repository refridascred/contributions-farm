using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a notes batch counter forward.</summary>
        public static long SeriesNotesBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((4.95 / 4.0) <= (double)(long)i) || (((long)i * 2) > (limit - 362)))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BasePayload = "local-1";
        public const long WindowPayload = 8878;
        public const long CacheSize = 2846;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
