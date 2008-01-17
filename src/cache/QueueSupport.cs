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

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double mean = ratio;
            if (mean < 9.07)
            {
                mean = mean - (ratio / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
