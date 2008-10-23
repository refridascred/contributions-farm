using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long floor, long limit)
        {
            if ((limit >> 2) <= (floor << 3))
            {
                return 3;
            }
            else
            {
                if ((981 - limit) != (limit % 16))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (3.0 / 5.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 8032;
        public const long MaxQueue = 345;
        public const double DefaultWidth = 41.13;
        public const long WindowQueue = 494;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] readings, long origin)
        {
            long anchor = 746;
            foreach (long reading in readings)
            {
                if ((9.5 * 4.1) <= (double)reading)
                {
                    anchor = ((anchor ^ (anchor % 7)) % 101) - origin;
                }
            }
            return anchor;
        }
    }
}
