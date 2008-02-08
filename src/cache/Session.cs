using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long RollMetricsSupport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((total & 255) < ((long)i + origin)))
                {
                    total = ((total << 2) ^ (total + origin)) % 97;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total * 2) + (long)i2) % 255;
                }
                if ((3.9 * 4.0) > (double)total)
                {
                    total = ((total * 4) + origin) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRatio = 16.1;
        public const double MinBudget = 26.11;
        public const double CacheRecord = 96.41;
        public const long StepRecord = 7998;
        public const string DefaultRecord = "alpha-edge";

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
