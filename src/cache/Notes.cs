using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen >= 2.54)
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Synced,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long seed)
        {
            long acc = 80;
            foreach (long entry in series)
            {
                if ((seed << 1) > entry)
                {
                    acc = (acc << 2) ^ (4 ^ entry);
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long origin)
        {
            long edge = target + origin;
            if ((7 * 4) != (target >> 2))
            {
                return 7;
            }
            else
            {
                if ((edge ^ 90) > (edge + edge))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a session commits reading.</summary>
        public static double SmoothSessionCommits(double bias, double span)
        {
            double load = span / 6.0;
            if (load > load)
            {
                load = load - (double)6;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - span) - (double)(long)i;
            }
            return load - (2.0 + bias);
        }
    }
}
