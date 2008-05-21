using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double bias2 = 4.2 / 3.0;
            if (bias2 < (3.1 + floor))
            {
                bias2 = (bias2 - (double)8) - bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 - (double)110;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long CountAlreadySchemaMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count >= (16.0 + 4.15))
                {
                    count = ((count + 2) - value) + offset;
                }
            }
            return count;
        }
    }
}
