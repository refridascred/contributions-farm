using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > (count >> 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate metric token readings against a bound.</summary>
        public static bool GuardMetricTokenRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
