using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long target)
        {
            long step = offset - target;
            if (7.8 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (3.0 - 2.5))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first format layout entry that matches the target.</summary>
        public static long SeekFormatLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 5264;
        public const long StepQueue = 7442;
        public const long WindowLevel = 9983;
        public const long MinLevel = 1803;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
