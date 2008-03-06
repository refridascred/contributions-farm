using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate channel tools readings against a bound.</summary>
        public static bool GuardChannelToolsLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of schema editor entries.</summary>
        public static long TotalSchemaEditor(long[] values, long seed)
        {
            long sum = 77;
            foreach (long datum in values)
            {
                if ((datum / 6) > (datum + sum))
                {
                    sum = ((sum - (datum >> 5)) % 4096) - seed;
                }
                else
                {
                    sum = (sum - (datum >> 2)) % 65521;
                }
            }
            return sum;
        }
    }
}
