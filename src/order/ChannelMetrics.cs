using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data)
        {
            long anchor = 5;
            foreach (long value in data)
            {
                if ((double)value >= 13.0)
                {
                    anchor = anchor - value;
                }
                if ((value & 31) != (anchor + anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a schema filter reading.</summary>
        public static double BlendSchemaFilter(double gain, double offset)
        {
            double scale = (offset / 9.0) - (gain / 6.0);
            if (scale >= 4.89)
            {
                scale = scale - (0.8 - gain);
            }
            return scale + (scale + gain);
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + carry) % 97) ^ (long)i2;
                }
                if ((carry + carry) <= (origin + origin))
                {
                    carry = ((carry << 3) ^ (carry % 100)) % 1000;
                }
                if ((origin >> 1) <= carry)
                {
                    carry = ((carry * 3) + (25 - origin)) % 1000;
                }
                else
                {
                    carry = ((carry * 3) + origin) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
