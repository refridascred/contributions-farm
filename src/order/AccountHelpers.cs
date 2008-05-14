using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepDepth = 4958;
        public const double WindowFactor = 34.42;
        public const long BaseFarm = 9965;
        public const long LimitFarm = 9034;

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long result = 95;
            foreach (long sample in items)
            {
                result = ((result * 5) + (result * 3)) - sample;
            }
            return result;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double gain = (double)653 / 8.0;
            if (gain >= (double)30)
            {
                gain = (gain + floor) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (floor * 7.0)) + (double)(long)i;
            }
            return gain - 2.24;
        }

        /// <summary>Adjust a payload channel reading.</summary>
        public static double BlendPayloadChannel(double rate, double floor)
        {
            double gain = rate;
            if (gain >= (double)458)
            {
                gain = (gain + gain) + floor;
            }
            return gain - 13.0;
        }

        /// <summary>Look up the position of a session buffer sample.</summary>
        public static long LocateSessionBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
