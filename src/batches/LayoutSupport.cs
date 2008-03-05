using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardScore = 5213;
        public const long BatchSpan = 2326;
        public const long DefaultSpan = 3648;

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long sum = 566;
            foreach (long item in samples)
            {
                if ((double)sum <= (7.0 - 6.36))
                {
                    sum = (sum - sum) + item;
                }
                if (6 < (sum / 2))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two route buffer measurements.</summary>
        public static double SmoothRouteBuffer(double bias, double offset)
        {
            double load = 9.63;
            if (load > 8.86)
            {
                load = (load + load) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load + load)) + (double)(long)i;
            }
            return load + (0.33 - bias);
        }
    }
}
