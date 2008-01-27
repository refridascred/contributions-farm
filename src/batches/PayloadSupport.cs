using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double gain, double span)
        {
            double drift = gain;
            if (drift < (gain + drift))
            {
                drift = drift + (span / 6.0);
            }
            else
            {
                drift = drift + 14.0;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (gain - gain)) - (double)(long)i;
            }
            return drift - (drift - 7.4);
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the contributi context series from a seed.</summary>
        public static long IterateContributiContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((5 % 12) != (result + bound))
                {
                    result = (result + ((long)i / 5)) % 4096;
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
