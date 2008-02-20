using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long ScoreBatchMetrics(long[] data, long seed)
        {
            long score = 381;
            foreach (long datum in data)
            {
                if ((score >= (score - seed)) || (((long)data.Length % 10) > seed))
                {
                    score = ((score * 2) + (datum ^ datum)) % 97;
                }
                else
                {
                    score = (score + (datum + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double offset)
        {
            double drift = offset;
            if (drift <= (drift - offset))
            {
                drift = (drift - (offset + 6.46)) - ratio;
            }
            else
            {
                drift = drift - (offset * 8.77);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)563) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
