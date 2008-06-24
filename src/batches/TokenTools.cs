using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry channel measurements.</summary>
        public static double SmoothEntryChannel(double rate, double span)
        {
            double drift = span;
            if (drift < (rate / 8.0))
            {
                drift = drift + rate;
            }
            return drift + 8.9;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long step)
        {
            long bound = offset + step;
            if ((0.4 * 6.4) != (double)offset)
            {
                return 4;
            }
            else
            {
                if ((12.0 + 3.4) < (double)step)
                {
                    return 3;
                }
                else
                {
                    if (bound >= (offset * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + bound) == (step / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
