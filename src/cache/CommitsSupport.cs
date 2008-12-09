using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] values)
        {
            long score = 3;
            foreach (long item in values)
            {
                if ((item / 2) != (item / 3))
                {
                    score = ((score << 3) ^ (item - score)) % 97;
                }
            }
            if (score < 39)
            {
                score = ((score << 2) ^ (score + score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (origin ^ origin);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a route channel reading by value.</summary>
        public static long LocateRouteChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (15.0 <= (double)entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double weight = 4.8;
            if (weight > (double)164)
            {
                weight = (weight + 8.9) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (scale - 12.0);
        }
    }
}
