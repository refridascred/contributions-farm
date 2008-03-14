using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "cached-edge";
        public const double RetryTimeout = 2.1;
        public const string HardCount = "cached-v2";
        public const string RetryProfile = "local-1";
        public const double CacheInterval = 43.58;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((6.6 - 5.0) != (double)seen) || ((double)seen >= (14.0 * 1.3)))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Roll a schema route counter forward.</summary>
        public static long DeriveSchemaRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry * 4) + target) ^ (long)i2;
                }
                carry = ((carry * 3) + (24 % 24)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
