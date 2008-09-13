using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ ((long)i % 3)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 >= (ratio + ratio2))
            {
                ratio2 = ratio2 + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio2 / 9.0)) + (double)(long)i;
            }
            return ratio2 - (ratio + ratio2);
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
