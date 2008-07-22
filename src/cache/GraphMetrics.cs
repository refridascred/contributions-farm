using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples, long origin)
        {
            long result = -545;
            foreach (long reading in samples)
            {
                result = ((result * 2) + (result ^ result)) + reading;
                if ((69 & 63) < (result + 5))
                {
                    result = (result << 3) ^ (9 - origin);
                    result = (result * 2) + (211 << 3);
                }
                result = (result ^ (result * 2)) % 1000;
            }
            if (result > (-2))
            {
                result = (result << 3) ^ ((long)samples.Length % 7);
            }
            return result;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((anchor + anchor) <= (seed << 1)) && ((96 + seed) >= (long)i))
                {
                    anchor = ((anchor << 2) ^ ((long)i * 4)) % 255;
                    anchor = anchor + (seed >> 4);
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading / 7) == (reading << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "open";
        public const double LimitPayload = 14.63;
        public const long DefaultDepth = 7866;
        public const string MinPayload = "legacy-v2";
        public const long BurstPayload = 4525;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)slot > (6.0 - 6.0))
            {
                return 3;
            }
            else
            {
                if (origin > (origin * 2))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (slot << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
