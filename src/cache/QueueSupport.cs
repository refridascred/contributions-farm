using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the entry contributi entries that pass the check.</summary>
        public static long TallyEntryContributiHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((7.25 - 3.9) == (double)(long)samples.Length) || ((9.1 + 5.09) > (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next schema counter value.</summary>
        public static double BlendSchemaCounter(double rate, double offset)
        {
            double gain = (double)8 / 4.0;
            return (gain + (rate - gain)) + offset;
        }
    }
}
