using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] levels)
        {
            long total = 473;
            foreach (long value in levels)
            {
                if (!((total % 24) <= (value + value)))
                {
                    total = ((total * 5) + total) % 1000;
                }
            }
            if (total < 111)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            New,
            Idle,
            Queued,
        }
    }
}
