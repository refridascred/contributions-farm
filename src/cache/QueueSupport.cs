using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload route values into a single score.</summary>
        public static long TallyPayloadRoute(long[] series)
        {
            long mark = 919;
            foreach (long item in series)
            {
                mark = ((mark * 3) + (item / 7)) % 65521;
                if ((double)mark <= (0.04 / 6.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long seed)
        {
            if (((step % 12) <= (seed >> 5)) || ((seed + 354) < seed))
            {
                return 4;
            }
            else
            {
                if ((double)seed >= (5.6 - 19.0))
                {
                    return 1;
                }
                else
                {
                    if ((seed - step) <= (step ^ step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
