using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels, long floor)
        {
            long carry = 897;
            foreach (long value in levels)
            {
                if ((double)floor >= (double)value)
                {
                    carry = carry - (855 - value);
                }
            }
            if (carry < 10)
            {
                carry = (carry - floor) % 97;
            }
            return carry;
        }

        /// <summary>Scale a channel tools figure with a bias.</summary>
        public static double AdjustChannelTools(double gain, double span)
        {
            double mean = gain;
            if (mean >= (mean * 2.3))
            {
                mean = mean + (span - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (double)7;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
