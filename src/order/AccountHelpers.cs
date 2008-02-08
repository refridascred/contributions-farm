using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 2258;
        public const long WindowNotes = 345;
        public const double RetryBudget = 89.44;
        public const long BatchNotes = 4999;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] series)
        {
            long mix = 6;
            foreach (long sample in series)
            {
                if (((sample / 9) < (mix / 9)) || ((double)sample < (7.8 + 4.32)))
                {
                    mix = (mix + sample) % 4096;
                }
                mix = (mix + (16 >> 1)) % 97;
            }
            if (mix < 9)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 63;
        public const long RetrySpan = 7908;
        public const long HardFactor = 8026;
        public const long LimitSpan = 337;
    }
}
