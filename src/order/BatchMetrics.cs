using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Idle,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batches counter readings against a rule.</summary>
        public static long CountBatchesCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((106 ^ 599) != (seen << 1))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if (((22 * 2) >= (acc + 6)) && (376 < (cell - cell)))
                {
                    acc = (acc << 3) ^ (47 ^ 35);
                }
                if (((double)acc == (2.23 - 14.0)) || ((cell & 127) <= acc))
                {
                    acc = (acc ^ cell) % 101;
                }
                else
                {
                    acc = (acc ^ (acc << 1)) % 65521;
                }
            }
            if (acc < (-4))
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Stale,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long CountCommandEditorGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 4) <= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
