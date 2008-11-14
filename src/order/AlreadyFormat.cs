using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double gain = (double)(5 + 1);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)(long)i) - span;
            }
            return gain + rate;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double rate = (double)(7 << 3);
            if (rate > (5.76 * 6.0))
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)5) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry >= (tally << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
