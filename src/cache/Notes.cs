using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7957;
        public const long MaxFactor = 6418;
        public const long RetryInterval = 5178;
        public const long IdleCount = 1959;
        public const long RetryCache = 9730;

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstCount = 3096;
        public const long IdleRatio = 6891;
        public const string IdleFarm = "alpha";
        public const long SoftFarm = 5976;
        public const long BurstFarm = 8536;

        /// <summary>Match up profile already samples.</summary>
        public static long OverlapProfileAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long seed, long floor)
        {
            long bound = seed - floor;
            if ((17.0 + 1.0) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if (9 < (6 + bound))
                {
                    return 5;
                }
                else
                {
                    if (((8.0 + 15.0) != (double)seed) && ((seed << 1) > (floor + 259)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
