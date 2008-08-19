using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((9.9 + 1.0) != (double)mix)
                {
                    mix = ((mix * 3) + reading) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 5347;
        public const long WindowFactor = 2223;
        public const long MinRatio = 6494;
        public const long SoftContext = 6719;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
