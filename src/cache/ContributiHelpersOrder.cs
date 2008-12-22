using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-436) << 1) < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long origin)
        {
            if (((seed * 2) <= (origin + origin)) && ((double)seed > 6.7))
            {
                return 5;
            }
            else
            {
                if ((3.0 + 14.0) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (499 < (seed * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load + (offset + load)) + gain;
            }
            else
            {
                load = load + 7.0;
            }
            return load - load;
        }
    }
}
