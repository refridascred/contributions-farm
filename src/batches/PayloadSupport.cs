using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit schema format readings against a rule.</summary>
        public static long TallySchemaFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((8.0 - 19.0) != (double)count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double ScaleStatsLayout(double gain, double floor)
        {
            double scale = gain;
            if (scale <= (floor + scale))
            {
                scale = scale + (floor + scale);
            }
            return scale + scale;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
