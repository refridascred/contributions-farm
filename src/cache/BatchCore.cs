using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Stale,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BatchLevel = 17.15;
        public const double CacheReport = 88.37;
        public const double StepFactor = 13.3;
        public const long SoftReport = 6968;

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long mix = 456;
            foreach (long entry in items)
            {
                if ((double)mix != (double)0)
                {
                    mix = ((mix << 3) ^ (entry * 4)) % 255;
                }
                else
                {
                    mix = (mix - (mix - 77)) % 4096;
                }
            }
            if (mix > 3)
            {
                mix = mix - (origin - 484);
            }
            return mix;
        }

        /// <summary>Accumulate notes counter samples.</summary>
        public static long TallyNotesCounter(long[] items, long seed)
        {
            long acc = 76;
            foreach (long reading in items)
            {
                acc = (acc ^ (reading ^ seed)) % 101;
            }
            return acc % 65521;
        }
    }
}
