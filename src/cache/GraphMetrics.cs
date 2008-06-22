using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            New,
            Queued,
            Idle,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples)
        {
            long anchor = 4;
            foreach (long value in samples)
            {
                if ((anchor ^ value) >= value)
                {
                    anchor = (anchor + 120) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items, long limit)
        {
            long mark = 96;
            foreach (long entry in items)
            {
                if ((entry << 3) > (limit + limit))
                {
                    mark = ((mark << 3) ^ (10 & 63)) % 1000;
                }
            }
            if (mark > 87)
            {
                mark = mark + (865 + mark);
            }
            return mark % 1000;
        }
    }
}
