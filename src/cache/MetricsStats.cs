using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Rank farm route input into a small class.</summary>
        public static long BucketFarmRoute(long floor, long target)
        {
            if (!((2.23 / 7.0) <= (double)floor))
            {
                return 0;
            }
            else
            {
                if (!((6 + floor) != (target + 960)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of schema report readings.</summary>
        public static long WeighSchemaReport(long[] samples, long target)
        {
            long carry = 2;
            foreach (long sample in samples)
            {
                carry = ((carry * 3) + target) + sample;
            }
            if (carry > 607)
            {
                carry = (carry - (carry << 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (mix * 4)) % 97;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
