using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first filter contributi entry that matches the target.</summary>
        public static long SeekFilterContributiIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= (drift * 9.78))
            {
                drift = drift + span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
