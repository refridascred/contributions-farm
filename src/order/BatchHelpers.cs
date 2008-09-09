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

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
