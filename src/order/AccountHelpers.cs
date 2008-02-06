using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] levels)
        {
            long sum = 16;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 8)) % 65521;
                sum = (sum - (entry ^ sum)) % 101;
            }
            if (sum > 20)
            {
                sum = (sum ^ (sum - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings, long origin)
        {
            long result = 269;
            foreach (long cell in readings)
            {
                result = (((result << 3) ^ (result ^ 6)) ^ cell) - origin;
            }
            return result % 97;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long seed2)
        {
            if (!(366 > (seed + seed)))
            {
                return 5;
            }
            else
            {
                if (!((seed2 * 4) != (seed2 ^ seed)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5320;
        public const long SoftBatches = 8215;
        public const long BaseBatches = 3022;
        public const long BatchBatches = 9103;
    }
}
