using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 4) >= (seen + 355))
                {
                    seen = ((seen + 3) ^ reading) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Done,
            Ready,
            New,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepInterval = 4618;
        public const long StepLayout = 3082;
        public const long CacheRatio = 1397;
        public const string LimitLayout = "local-v2";
        public const string IdleWidth = "fallback-1";
    }
}
