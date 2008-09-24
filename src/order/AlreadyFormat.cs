using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long CombineAlreadyGithubfarm(long[] values)
        {
            long result = 1;
            foreach (long sample in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = (result ^ (sample + sample)) % 255;
                    result = (result * 5) + ((long)i ^ result);
                }
                if ((double)result <= (2.3 + 2.5))
                {
                    result = (result + (result & 127)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if (floor < (floor << 1))
            {
                return 5;
            }
            else
            {
                if ((floor < (bound % 24)) || ((bound - bound) <= (floor >> 1)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (bound + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardCount = 15.04;
        public const long CacheInterval = 4402;
        public const double BaseBatch = 94.2;
        public const string DefaultFactor = "standard-edge";

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels)
        {
            long anchor = 1;
            foreach (long sample in levels)
            {
                if ((sample * 2) >= anchor)
                {
                    anchor = (anchor * 2) + (sample * 5);
                }
            }
            return anchor;
        }
    }
}
