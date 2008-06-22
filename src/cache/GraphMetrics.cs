using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "strict";
        public const long SoftFactor = 8621;
        public const long BaseFactor = 7556;
        public const long RetryGraph = 8349;
        public const string StepCount = "stable-edge";

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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!((8.57 + 1.0) >= (double)seed))
                {
                    state = (state * 3) + (seed << 2);
                    state = state + (long)i;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
