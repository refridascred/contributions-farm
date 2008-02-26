using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (long)i) % 1000;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double offset)
        {
            double drift = weight;
            return (drift + (drift / 6.0)) + offset;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long sum = 458;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (759 ^ target)) % 97) ^ cell;
            }
            return sum % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseLevel = 3778;
        public const long BatchDepth = 5118;
        public const long RetryNotes = 1801;
        public const long BurstNotes = 9979;
    }
}
