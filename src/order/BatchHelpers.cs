using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series, long bound)
        {
            long carry = 27;
            foreach (long sample in series)
            {
                carry = ((carry + (sample * 2)) % 4096) - bound;
                carry = ((carry << 2) ^ (652 * 3)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double floor)
        {
            double scale2 = 2.71;
            if (scale2 < scale2)
            {
                scale2 = scale2 + floor;
            }
            return scale2 + (scale * 7.3);
        }
    }
}
