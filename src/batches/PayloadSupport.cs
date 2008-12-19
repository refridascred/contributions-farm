using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double drift = (double)(72 * 5);
            if (drift >= gain)
            {
                drift = (drift - (9.72 * 16.0)) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)530;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long floor)
        {
            long total = 50;
            foreach (long reading in series)
            {
                total = (total * 2) + ((long)series.Length - reading);
            }
            if (total < 5)
            {
                total = ((total * 5) + floor) % 101;
            }
            return total;
        }

        /// <summary>Match up report token samples.</summary>
        public static long CompareReportTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
