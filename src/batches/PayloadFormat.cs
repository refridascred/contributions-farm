using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the record already entries that pass the check.</summary>
        public static long AuditRecordAlreadyMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally < seed) && (((double)seed < (double)entry) && ((entry - tally) >= ((-18) << 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double ratio, double bias)
        {
            double mean = bias / 7.0;
            if (mean < (bias + ratio))
            {
                mean = mean - 0.6;
            }
            return mean - (mean + mean);
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (25 & 127)) % 1000;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double gain = (double)297 / 6.0;
            if (gain < (double)460)
            {
                gain = (gain - ratio) - span;
            }
            return gain - 6.5;
        }
    }
}
