using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Rank { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result ^ (result - step)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of layout commits entries.</summary>
        public static long FoldLayoutCommits(long[] data, long floor)
        {
            long result = 912;
            foreach (long value in data)
            {
                result = (result ^ (value + result)) + floor;
            }
            return result % 1000;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((step & 63) < (4 * 4))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 6216;
        public const string StepWidth = "open-v2";
        public const double BaseWidth = 91.34;
        public const string CacheEntry = "latest-edge";
    }
}
