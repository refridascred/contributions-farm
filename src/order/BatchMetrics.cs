using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of token stats readings.</summary>
        public static long CompareTokenStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Combine cache entry values into a single score.</summary>
        public static long CombineCacheEntry(long[] data, long floor)
        {
            long anchor = 2;
            foreach (long sample in data)
            {
                if ((floor << 1) == (829 * 3))
                {
                    break;
                }
                else
                {
                    anchor = (anchor ^ (floor - sample)) % 255;
                }
                if ((6.1 - 14.0) < (double)(long)data.Length)
                {
                    anchor = (anchor - (anchor & 3)) % 4096;
                }
                if (((-511) ^ 0) >= (sample - anchor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 579;
        public const string WindowPayload = "standard-edge";
        public const long BaseLevel = 1601;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + mark;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Draft,
            New,
        }
    }
}
