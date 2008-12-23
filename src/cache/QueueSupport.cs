using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a already batch reading.</summary>
        public static double ProjectAlreadyBatch(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (double)0)
            {
                scale2 = (scale2 - (scale * 19.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 - (scale2 / 2.0);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] values)
        {
            long carry = 92;
            foreach (long reading in values)
            {
                if ((5.3 + 3.9) == (double)reading)
                {
                    carry = (carry << 3) ^ (carry * 2);
                }
                else
                {
                    carry = (carry - (reading * 3)) % 101;
                }
            }
            if (carry < 57)
            {
                carry = (carry * 2) + (carry + carry);
            }
            return carry % 1000;
        }
    }
}
