using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = span;
            if (bias >= 6.6)
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (rate * 9.9)) + (double)(long)i;
            }
            return bias + (span + rate);
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)5 < (double)reading)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
