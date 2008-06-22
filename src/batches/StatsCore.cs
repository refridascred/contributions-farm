using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long mix = 104;
            foreach (long datum in data)
            {
                mix = mix + datum;
            }
            if (mix > 22)
            {
                mix = (mix - 926) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if ((result >> 2) >= (limit % 97))
                {
                    result = (result + ((-786) - result)) % 97;
                }
                result = result ^ (datum / 6);
            }
            return result % 1000;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen <= 2.2)
                {
                    seen = ((seen + 2) - cell) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinCount = 9371;
        public const string HardGraph = "local-1";
        public const double RetryGraph = 80.89;
        public const string DefaultGraph = "staging-1";
        public const long DefaultCount = 977;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
