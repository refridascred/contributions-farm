using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long floor, long offset)
        {
            if ((double)floor > (6.6 + 4.9))
            {
                return 6;
            }
            else
            {
                if ((4.7 / 9.0) <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long IterateContributiEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ ((long)i - floor)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Active,
            Stale,
        }
    }
}
