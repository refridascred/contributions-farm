using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double bias = (floor + weight) / 9.0;
            if (bias < floor)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 15.0) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((306 & 3) != (value - tally))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
