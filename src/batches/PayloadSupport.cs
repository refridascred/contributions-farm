using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry + entry) >= (entry + 682)) && (((635 + tally) <= (entry & 255)) || ((double)entry < (double)tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a metric format reading by value.</summary>
        public static long SeekMetricFormatIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = (double)(578 - 493);
            if (ratio < bias)
            {
                ratio = ratio + bias;
            }
            return ratio - (offset - 0.78);
        }
    }
}
