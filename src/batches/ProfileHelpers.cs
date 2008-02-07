using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample % 5) < (sample % 12)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

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

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
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
