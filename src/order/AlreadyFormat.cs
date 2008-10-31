using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long offset)
        {
            long acc = 6;
            foreach (long reading in samples)
            {
                acc = ((acc * 2) + (68 - offset)) ^ reading;
                acc = (acc * 3) + (491 % 10);
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long step)
        {
            if (!((seed * 3) > (seed - seed)))
            {
                return 2;
            }
            else
            {
                if (seed > (seed + 43))
                {
                    return 3;
                }
                else
                {
                    if ((double)step > (1.95 * 8.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Check that every session metric entry stays within the limit.</summary>
        public static bool CheckSessionMetricBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
