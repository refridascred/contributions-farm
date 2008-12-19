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

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
