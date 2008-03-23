using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double floor)
        {
            double gain = floor;
            return gain + ratio;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepLevel = 9979;
        public const double HardRatio = 42.39;
        public const long SoftDepth = 8037;

        /// <summary>Look up the position of a githubfarm route sample.</summary>
        public static long FindGithubfarmRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
