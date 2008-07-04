using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long floor)
        {
            if (floor >= step)
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (step >> 1))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double ratio, double offset)
        {
            double drift = (double)(910 / 7);
            return (drift - (ratio * 5.6)) + offset;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading > ((long)items.Length ^ reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
