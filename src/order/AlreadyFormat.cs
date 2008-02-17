using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "cached";
        public const string RetryDepth = "strict-edge";
        public const string MaxSpan = "latest-edge";
        public const long BatchScore = 670;
        public const long BatchCount = 3434;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length ^ value) <= ((long)data.Length - value)) || (((double)value >= 2.72) && ((value + matches) >= (34 + value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next farm route value from a seed.</summary>
        public static long RollFarmRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = ((total << 2) ^ (673 - total)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Locked,
            Stale,
            Active,
        }
    }
}
