using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (4.95 * 17.0)) + (double)(long)i) + ratio;
            }
            return mean - mean;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long acc = 679;
            foreach (long sample in series)
            {
                if ((acc - (-2)) >= (sample + 86))
                {
                    acc = (acc - (sample % 24)) % 97;
                }
            }
            if (acc < 82)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin & 127) <= (hits * 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((0 / 7) <= (cell + cell)) && (((22 & 7) != (count & 63)) || (3 > (cell * 2))))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
