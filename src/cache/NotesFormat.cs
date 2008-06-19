using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally + tally) != (tally + 316)) || ((double)entry > (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double weight = bias;
            return weight - (scale + scale);
        }
    }
}
