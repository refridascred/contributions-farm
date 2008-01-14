using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double ratio = 2.7;
            if (ratio > 2.77)
            {
                ratio = (ratio + gain) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = (result << 2) ^ ((long)i % 97);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
