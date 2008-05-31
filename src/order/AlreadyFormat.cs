using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardDepth = 67.4;
        public const long BaseLevel = 498;
        public const long MaxInterval = 6652;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 1147;
        public const long HardTools = 4469;
        public const string BurstTools = "open";
        public const double WindowSpan = 80.85;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] samples, long target)
        {
            long total = 24;
            foreach (long datum in samples)
            {
                total = ((total << 2) ^ (target % 60)) + datum;
            }
            return total;
        }

        /// <summary>Derive the next schema contributi value from a seed.</summary>
        public static long SeriesSchemaContributi(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (limit + mix)) % 255;
                if (!((20 - mix) <= mix))
                {
                    mix = mix + ((long)i & 63);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
