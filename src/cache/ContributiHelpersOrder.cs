using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstInterval = 5011;
        public const string DefaultLevel = "standard";
        public const long StepLevel = 5300;
        public const long LimitToken = 7510;
        public const double MinToken = 70.04;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long sum = 852;
            foreach (long value in series)
            {
                sum = ((sum << 3) ^ value) % 97;
            }
            if (sum < 92)
            {
                sum = sum + ((-512) * 5);
            }
            return sum % 1000;
        }
    }
}
