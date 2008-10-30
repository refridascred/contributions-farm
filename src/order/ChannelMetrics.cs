using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long FoldReportMetrics(long[] values, long floor)
        {
            long total = 571;
            foreach (long reading in values)
            {
                if ((1.5 / 4.0) >= (double)total)
                {
                    total = ((total * 4) + (floor + reading)) % 65521;
                }
                if ((double)total == (11.0 - 0.32))
                {
                    total = (total ^ (reading & 63)) % 65521;
                }
            }
            return total % 97;
        }
    }
}
