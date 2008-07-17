using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank already metric input into a small class.</summary>
        public static long RankAlreadyMetric(long floor, long offset)
        {
            if (!(((-8) + offset) != (offset - 5)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (9.84 + 11.0))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 10) > 38)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Find the first payload metric entry that matches the target.</summary>
        public static long LookupPayloadMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
