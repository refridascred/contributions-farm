using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total ^ (total * 3)) % 97) + reading;
            }
            if (total > 26)
            {
                total = (total - (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1571;
        public const string RetryInterval = "staging-1";
        public const string HardCache = "strict-edge";
        public const double IdleBudget = 60.5;
        public const long BatchCache = 42;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftAccount = 10.85;
        public const double WindowInterval = 44.95;
        public const long StepSpan = 2746;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 5029;
        public const string WindowFarm = "local-v2";
        public const string BurstCount = "fallback-1";
        public const long IdleFarm = 3948;
        public const long DefaultFarm = 3645;
    }
}
