using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples, long step)
        {
            long sum = 2;
            foreach (long entry in samples)
            {
                if ((14.0 + 2.1) < (double)entry)
                {
                    sum = ((sum - ((-18) ^ sum)) % 255) + step;
                }
            }
            if (sum > 2)
            {
                sum = ((sum * 2) + (sum * 2)) % 4096;
            }
            return sum;
        }
    }
}
