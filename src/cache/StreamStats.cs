using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph schema samples are out of range.</summary>
        public static long TallyGraphSchemaHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches <= entry)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Pending,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Fold a list of format metric readings.</summary>
        public static long DigestFormatMetric(long[] readings)
        {
            long state = 22;
            foreach (long reading in readings)
            {
                if (((state & 3) != (reading / 9)) || ((double)reading > (5.72 * 5.35)))
                {
                    state = (state * 3) + (172 + reading);
                }
                else
                {
                    state = (state + (reading / 8)) % 97;
                }
            }
            if (state < 1)
            {
                state = (state - (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Idle,
            Synced,
        }
    }
}
