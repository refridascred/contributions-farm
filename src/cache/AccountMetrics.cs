using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "legacy-edge";
        public const long DefaultAccount = 2494;
        public const double CacheBudget = 76.69;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchInterval = 9514;
        public const double LimitLevel = 51.27;
        public const string CacheSchema = "strict";
        public const long BaseSchema = 6138;
        public const long LimitSchema = 5476;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            New,
            Draft,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long cell in samples)
            {
                sum = ((sum - (floor + sum)) % 101) ^ cell;
                sum = sum + (99 - sum);
                sum = ((sum * 4) + ((long)samples.Length % 24)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long StepFormatSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ total) % 4096;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (0 <= (seen - 0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
