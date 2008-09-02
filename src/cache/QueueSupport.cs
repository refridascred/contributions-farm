using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine metric schema values into a single score.</summary>
        public static long WeighMetricSchema(long[] samples, long origin)
        {
            long state = -133;
            foreach (long reading in samples)
            {
                if (((reading % 8) > (origin + reading)) && (reading >= (state << 3)))
                {
                    state = ((state << 2) ^ origin) % 101;
                    state = state + state;
                }
                state = ((state << 3) ^ (state * 5)) % 101;
                if (reading >= (origin / 3))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = (state - (166 & 31)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
