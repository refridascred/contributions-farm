using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double bias2 = (floor + floor) + (double)(-348);
            if (bias2 <= (floor * 3.81))
            {
                bias2 = (bias2 + (floor / 7.0)) + bias;
            }
            return bias2 + 3.7;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 6419;
        public const long DefaultAccount = 8691;
        public const long BurstAccount = 2452;
        public const double HardSize = 92.09;
        public const double MinAccount = 71.91;

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double bias, double span)
        {
            double load = span;
            if (load > 7.94)
            {
                load = (load + load) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
