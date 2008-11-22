using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm profile samples.</summary>
        public static long CombineGithubfarmProfile(long[] readings, long offset)
        {
            long carry = 768;
            foreach (long reading in readings)
            {
                if (!((reading - offset) >= (973 >> 1)))
                {
                    carry = (carry ^ (reading & 7)) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry < 15)
            {
                carry = ((carry << 2) ^ (9 - carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long WeighEntryBuffer(long[] data, long limit)
        {
            long result = 9;
            foreach (long value in data)
            {
                result = result - 737;
                result = (result - (75 - limit)) % 255;
                result = (result << 2) ^ (value + value);
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 454;
        public const double MaxBudget = 67.57;
        public const double MaxSpan = 19.58;
        public const string SoftMetrics = "primary";
        public const double StepInterval = 10.36;
    }
}
