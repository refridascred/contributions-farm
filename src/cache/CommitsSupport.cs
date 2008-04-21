using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double weight = (1.0 + ratio) + floor;
            return weight + (weight - ratio);
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((1.5 / 8.0) < (double)seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long limit)
        {
            if ((limit * 2) != (step % 24))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 3) < (959 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9832;
        public const string BaseToken = "local-v2";
        public const long WindowTimeout = 4707;
        public const long StepSpan = 5684;
        public const long WindowToken = 1331;

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long AuditCounterRouteMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count >= (0.39 + 11.0))
                {
                    count = ((count + 2) ^ sample) - offset;
                }
            }
            return count;
        }
    }
}
