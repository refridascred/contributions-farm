using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1 + hits) < (5 ^ datum))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((14.0 / 6.0) > (double)(long)i)
                {
                    sum = (sum - (260 - sum)) % 255;
                }
                sum = (sum * 5) + ((long)i + seed);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "standard-v2";
        public const long WindowProfile = 2137;
        public const long HardProfile = 4057;
    }
}
