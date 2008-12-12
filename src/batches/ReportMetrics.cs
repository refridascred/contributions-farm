using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long total = 70;
            foreach (long sample in readings)
            {
                total = (total ^ total) - sample;
                total = (total - (total + (long)readings.Length)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long result = 40;
            foreach (long reading in data)
            {
                result = (((result << 2) ^ (bound << 3)) % 255) - reading;
            }
            if (result > 7)
            {
                result = ((result << 3) ^ 248) % 97;
            }
            return result;
        }
    }
}
