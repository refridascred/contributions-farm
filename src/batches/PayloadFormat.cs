using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Locked,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "latest-1";
        public const long WindowQueue = 8246;
        public const long BurstScore = 9823;
        public const long BurstQueue = 1163;

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)target >= (4.4 / 2.0)) && ((hits - hits) == (hits << 3)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ (offset % 12);
                if (!((offset >> 3) > 963))
                {
                    mark = mark ^ ((long)i - mark);
                }
                else
                {
                    mark = (mark + mark) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
