using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (-576)) <= (long)data.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 9945;
        public const long CacheDepth = 1284;
        public const double MaxSize = 66.41;

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long ClassifyEntryMetric(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (origin >= (prev + origin))
            {
                return 6;
            }
            else
            {
                if ((origin & 127) < (seed + 52))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (step + 9)) % 101;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 3876;
        public const string BurstInterval = "local-1";
        public const long IdleFactor = 2443;
    }
}
