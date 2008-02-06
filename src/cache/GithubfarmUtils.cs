using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                long count = sum & 7;
                if ((double)sum == (double)(-25))
                {
                    sum = ((sum * 2) + count) % 97;
                    count = (count ^ count) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Validate batches tools readings against a bound.</summary>
        public static bool VerifyBatchesToolsLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
