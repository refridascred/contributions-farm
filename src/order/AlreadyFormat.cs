using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Ready,
            Pending,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double bias, double span)
        {
            double weight = span + (double)4;
            if (weight <= (double)0)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (bias * 3.07)) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = (result - (offset - (long)i)) - (long)i3;
                }
                result = (result ^ ((long)i >> 3)) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
