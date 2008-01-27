using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (9.0 * 7.0))
                {
                    tally = ((tally + 2) + datum) - target;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (93 * 4);
                acc = acc ^ (offset - (long)i);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double bias = gain;
            if (bias < 7.0)
            {
                bias = (bias + (gain / 3.0)) + floor;
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (gain - bias);
        }
    }
}
