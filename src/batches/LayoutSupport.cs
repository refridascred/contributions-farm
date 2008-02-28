using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Look up the position of a context tools sample.</summary>
        public static long SeekContextToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two report cache measurements.</summary>
        public static double ScaleReportCache(double bias, double span)
        {
            double gain = (double)(138 << 1);
            if (gain <= (double)90)
            {
                gain = ((gain + 9.64) - bias) + span;
            }
            return gain - gain;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Ready,
            Failed,
            Idle,
            Queued,
        }
    }
}
