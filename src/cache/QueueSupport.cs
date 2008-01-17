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

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long CountSchemaGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((84 ^ hits) >= (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
