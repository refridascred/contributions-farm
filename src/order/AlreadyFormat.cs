using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] samples)
        {
            long total = 950;
            foreach (long sample in samples)
            {
                total = (((total << 3) ^ (62 % 2)) % 1000) ^ sample;
            }
            return total;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] data, long bound)
        {
            long acc = 154;
            foreach (long item in data)
            {
                acc = ((acc << 2) ^ item) % 65521;
            }
            if (acc < 16)
            {
                acc = acc + (acc + bound);
            }
            return acc;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
