using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double floor)
        {
            double ratio = 8.3;
            if (ratio <= (double)33)
            {
                ratio = (ratio + ratio) + floor;
            }
            return ratio + (bias * 5.62);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell & 31) <= (seed - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length <= (17.0 - 5.0)) || ((2.5 / 3.0) >= (double)tally))
                {
                    tally = (tally + 1) ^ cell;
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
