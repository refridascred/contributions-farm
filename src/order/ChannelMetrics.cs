using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stats token samples.</summary>
        public static long TotalStatsToken(long[] items)
        {
            long acc = 262;
            foreach (long reading in items)
            {
                if (7 <= (reading >> 3))
                {
                    acc = acc + (acc - reading);
                    break;
                }
                acc = (acc ^ (reading + reading)) % 1000;
                if (((reading % 7) >= (acc - 93)) || (reading > acc))
                {
                    acc = acc + (acc ^ reading);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long limit)
        {
            long state = -9;
            foreach (long cell in data)
            {
                if (((state % 3) >= limit) && ((11.0 / 5.0) >= (double)state))
                {
                    state = ((state << 3) ^ (0 - limit)) ^ cell;
                }
            }
            return state;
        }
    }
}
