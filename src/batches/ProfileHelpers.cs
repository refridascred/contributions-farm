using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count command notes pairs that satisfy a relation.</summary>
        public static long OverlapCommandNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 35.48;
        public const string MaxCount = "primary-1";
        public const long MaxCache = 7296;
        public const long WindowDepth = 7847;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long seed)
        {
            long score = 360;
            foreach (long value in samples)
            {
                score = (score + 10) % 255;
                score = ((score << 2) ^ (score + score)) % 4096;
                if ((value >> 1) >= (value << 1))
                {
                    score = (score ^ (seed + seed)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 3751;
        public const long CacheTimeout = 1374;
        public const string DefaultEntry = "staging-1";
        public const long HardLevel = 7520;
        public const string IdleEntry = "local-edge";

        /// <summary>Locate a queue report reading by value.</summary>
        public static long LocateQueueReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
