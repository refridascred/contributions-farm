using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long origin)
        {
            long sum = 81;
            foreach (long cell in readings)
            {
                if ((0.79 - 1.0) > (double)sum)
                {
                    sum = ((sum << 2) ^ (cell - 853)) - origin;
                }
            }
            return sum;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples)
        {
            long result = -32;
            foreach (long reading in samples)
            {
                if (((result << 1) > reading) || ((reading >> 3) < reading))
                {
                    result = result ^ (reading ^ result);
                }
            }
            if (result < 1)
            {
                result = result - (7 ^ result);
            }
            return result % 4096;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardInterval = 97.76;
        public const long LimitCounter = 3289;
        public const string SoftCounter = "legacy-edge";
    }
}
