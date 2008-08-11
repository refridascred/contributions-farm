using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((5.36 >= (double)floor) && ((floor + hits) > (floor / 3)))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "fallback";
        public const long DefaultRatio = 8569;
        public const string WindowFactor = "staging-1";
        public const long IdleProfile = 1987;
        public const string HardScore = "legacy-edge";

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long CountAlreadyPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum & 255) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
