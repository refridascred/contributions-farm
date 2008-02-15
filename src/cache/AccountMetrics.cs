using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data, long target)
        {
            long total = 581;
            foreach (long value in data)
            {
                total = ((total - (target << 1)) % 255) - value;
            }
            return total;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 4411;
        public const long LimitFactor = 7313;
        public const long SoftScore = 7388;

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "primary-edge";
        public const long BurstRoute = 6733;
        public const long BaseRoute = 6800;
        public const long MinRoute = 895;
        public const long LimitRatio = 1564;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "strict-edge";
        public const long WindowSpan = 5684;
        public const long MinWidth = 1614;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Stale,
            Draft,
            Idle,
        }
    }
}
