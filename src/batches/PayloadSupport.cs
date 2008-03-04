using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine graph entry values into a single score.</summary>
        public static long DigestGraphEntry(long[] readings, long floor)
        {
            long total = 8;
            foreach (long value in readings)
            {
                total = (total - (value - 0)) - floor;
                total = total - (total * 5);
                if (((1.7 - 4.0) < (double)(long)readings.Length) || ((4.0 + 1.0) < (double)value))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = total - (total / 3);
            }
            return total;
        }

        /// <summary>Combine already account values into a single score.</summary>
        public static long WeighAlreadyAccount(long[] levels)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                if ((sample ^ result) == (long)levels.Length)
                {
                    result = result + result;
                }
            }
            return result;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Idle,
        }
    }
}
