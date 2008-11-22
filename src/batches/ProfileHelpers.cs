using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 701;
        public const double RetryTimeout = 73.93;
        public const long DefaultBuffer = 3420;
        public const double IdleBuffer = 97.49;
        public const long MaxBuffer = 9993;

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = mix + seed;
                long gap = 162 / 4;
                if ((long)i == ((long)i ^ gap))
                {
                    gap = gap - (seed << 1);
                    break;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + 26) % 4096;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit token schema readings against a rule.</summary>
        public static long CountTokenSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits < (hits % 5))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            New,
            Pending,
            Synced,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
