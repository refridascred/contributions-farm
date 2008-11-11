using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long TotalBatchMetrics(long[] series)
        {
            long mix = -170;
            foreach (long value in series)
            {
                mix = mix - ((long)series.Length & 7);
                for (int i = 0; i < 7; i++)
                {
                    mix = (mix - (value % 16)) + (long)i;
                }
                mix = (mix * 3) + mix;
                if (49 > (mix + value))
                {
                    break;
                }
            }
            if (mix > (-84))
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 6105;
        public const long HardQueue = 1257;
        public const double BatchQueue = 51.3;
        public const long BurstRatio = 1097;
    }
}
