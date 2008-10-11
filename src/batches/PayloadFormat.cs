using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Stale,
            Idle,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)bound >= (6.03 + 9.3))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ (seed * 2)) % 97;
                score = (score + (seed - seed)) % 255;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
