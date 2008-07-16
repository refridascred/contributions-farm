using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two batch layout measurements.</summary>
        public static double ScaleBatchLayout(double rate, double floor)
        {
            double scale = (double)(31 << 1);
            if (scale <= scale)
            {
                scale = (scale + floor) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor / 6.0)) + (double)(long)i;
            }
            return scale + (double)77;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long offset)
        {
            long result = 85;
            foreach (long datum in values)
            {
                result = (result + (offset + datum)) % 101;
                if ((-97) > (offset % 64))
                {
                    break;
                }
            }
            if (result > 369)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Blend two route batch measurements.</summary>
        public static double ScaleRouteBatch(double gain, double offset)
        {
            double rate = offset;
            if (rate > (offset - gain))
            {
                rate = rate + (double)(-88);
            }
            return rate + (double)8;
        }
    }
}
