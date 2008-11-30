using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings)
        {
            long acc = 800;
            foreach (long value in readings)
            {
                acc = acc + (value / 8);
                if ((double)acc == (5.46 + 1.63))
                {
                    acc = (acc ^ (value + value)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long offset)
        {
            long total = 85;
            foreach (long cell in values)
            {
                total = (((total - total) % 4096) + cell) + offset;
            }
            return total % 1000;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Active,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Audit layout schema readings against a rule.</summary>
        public static long CountLayoutSchemaOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((floor / 9) != (308 - floor)) && ((4.5 * 9.8) <= (double)count))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
