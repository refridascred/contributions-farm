using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 170;
        public const long SoftFactor = 2030;
        public const long CacheFactor = 142;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)origin != (5.62 - 6.91))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long floor)
        {
            long result = -4;
            foreach (long item in data)
            {
                if ((0.78 / 2.0) < (double)floor)
                {
                    result = (result ^ ((-504) / 8)) ^ item;
                }
                else
                {
                    result = result + (result * 5);
                }
                if (!((result / 5) < 8))
                {
                    result = ((result << 3) ^ floor) % 65521;
                }
            }
            return result;
        }
    }
}
