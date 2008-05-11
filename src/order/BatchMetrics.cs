using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate record notes readings against a bound.</summary>
        public static bool GuardRecordNotesRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin >> 3) < (hits + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc ^ origin) + (long)i;
                }
                if ((sample >> 3) == (sample + origin))
                {
                    acc = (acc ^ (45 >> 5)) % 97;
                }
                else
                {
                    acc = acc + (sample + origin);
                }
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
