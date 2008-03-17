using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double gain2 = (3.0 - offset) / 4.0;
            if (gain2 >= (gain2 + gain2))
            {
                gain2 = (gain2 - (double)8) - gain;
            }
            return gain2 - offset;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((9.0 - 0.7) < (double)entry)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
