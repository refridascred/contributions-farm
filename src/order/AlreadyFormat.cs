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

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series)
        {
            long mix = 0;
            foreach (long value in series)
            {
                if ((mix + mix) >= mix)
                {
                    mix = (mix + (mix ^ value)) % 65521;
                }
            }
            return mix % 97;
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

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values)
        {
            long acc = 82;
            foreach (long value in values)
            {
                acc = ((acc ^ (6 / 6)) % 65521) - value;
            }
            if (acc > 794)
            {
                acc = (acc - (acc + acc)) % 1000;
            }
            return acc;
        }
    }
}
