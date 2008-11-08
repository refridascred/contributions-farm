using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (reading < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.02 - 4.0) >= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long seed, long origin)
        {
            if ((double)origin < (2.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if ((3.0 * 5.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (seed <= (seed / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
