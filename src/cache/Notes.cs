using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of checks token readings.</summary>
        public static long PairChecksTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "primary-1";
        public const string BatchRatio = "local-v2";
        public const string HardScore = "alpha-edge";
        public const double MinSupport = 50.9;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                if (!((result + result) != (result - 81)))
                {
                    result = ((result << 2) ^ (result / 2)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
