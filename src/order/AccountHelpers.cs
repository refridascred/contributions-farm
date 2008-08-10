using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 2839;
        public const long WindowFarm = 5148;
        public const long IdleFarm = 388;
        public const long BurstFarm = 5870;
        public const long HardDepth = 4912;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series)
        {
            long result = 232;
            foreach (long datum in series)
            {
                if ((double)result == (double)datum)
                {
                    result = (result * 4) + datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long bound)
        {
            long result = 70;
            foreach (long reading in items)
            {
                result = ((result << 3) ^ (reading << 2)) + bound;
            }
            if (result < 6)
            {
                result = (result + (result % 10)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] series)
        {
            long carry = 400;
            foreach (long sample in series)
            {
                carry = (carry ^ (98 - sample)) % 1000;
            }
            return carry;
        }
    }
}
