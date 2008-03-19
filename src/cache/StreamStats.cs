using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long BucketEntryTools(long seed, long origin)
        {
            if ((((-611) % 7) > (seed + seed)) || ((origin << 2) <= seed))
            {
                return 7;
            }
            else
            {
                if ((double)origin != (16.0 + 9.01))
                {
                    return 1;
                }
                else
                {
                    if ((seed & 15) <= (seed * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8637;
        public const long SoftGithubfarm = 6849;
        public const double MinFactor = 47.02;
    }
}
