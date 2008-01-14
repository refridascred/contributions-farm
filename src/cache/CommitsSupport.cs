using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 5990;
        public const double BurstCommits = 65.63;
        public const long RetryCommits = 6870;
        public const long HardCommits = 891;
        public const string CacheCommits = "alpha-1";

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 44.36;
        public const double StepFactor = 52.49;
        public const double RetryInterval = 21.47;
        public const long StepCommand = 8129;

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((double)seed >= (6.3 * 4.9))
            {
                return 1;
            }
            else
            {
                if ((floor - edge) >= (edge ^ floor))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
