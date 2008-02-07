using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleMetrics = 65.29;
        public const long BaseMetrics = 9000;
        public const long StepMetrics = 5309;
        public const long IdleSpan = 1648;
        public const long MinInterval = 4938;

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] data, long floor)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                carry = (carry - (carry - floor)) % 97;
                if (((sample & 7) <= (sample << 2)) || ((floor + sample) <= 1))
                {
                    carry = (carry ^ 406) % 65521;
                }
            }
            if (carry < 604)
            {
                carry = (carry - (floor & 7)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Check that every cluster account entry stays within the limit.</summary>
        public static bool ValidateClusterAccountLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double drift = (double)(-61);
            if (drift >= (4.2 / 8.0))
            {
                drift = ((drift - (double)(-249)) - bias) + span;
            }
            else
            {
                drift = drift - (9.5 - drift);
            }
            return drift - (double)801;
        }
    }
}
