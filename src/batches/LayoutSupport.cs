using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 28.06;
        public const long BurstCommits = 5150;
        public const long BurstWidth = 9534;
        public const long WindowCommits = 3851;
        public const double LimitCommits = 18.71;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
