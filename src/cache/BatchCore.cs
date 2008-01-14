using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema channel counter forward.</summary>
        public static long StepSchemaChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total + 344) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total << 3) ^ (total * 3)) % 97) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Size { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
