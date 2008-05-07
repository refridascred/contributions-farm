using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) == (sample & 31))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double load = 1.34 - (double)5;
            if (load > (0.12 - bias))
            {
                load = load + (span * 6.17);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((0.6 + 6.69) >= (double)count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
