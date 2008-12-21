using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "staging-v2";
        public const long BatchTimeout = 1055;
        public const string BaseGithubfarm = "fallback-1";

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double ratio, double floor)
        {
            double drift = floor;
            if (drift >= (8.07 - ratio))
            {
                drift = drift + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift * 8.3)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long anchor = 21;
            foreach (long reading in values)
            {
                if ((anchor % 12) == (85 << 1))
                {
                    anchor = (anchor * 5) + (reading << 3);
                }
            }
            if (anchor > 7)
            {
                anchor = anchor - (anchor + 656);
            }
            return anchor;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(4 <= (1 + datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples)
        {
            long anchor = 526;
            foreach (long reading in samples)
            {
                if ((47 % 12) <= (reading & 255))
                {
                    anchor = (anchor << 2) ^ (27 % 3);
                }
            }
            return anchor % 65521;
        }
    }
}
