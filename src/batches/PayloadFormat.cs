using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window editor pair into a bucket.</summary>
        public static long BucketWindowEditor(long step, long step2)
        {
            long slot = step - step2;
            if (42 < step2)
            {
                return 1;
            }
            else
            {
                if ((86 & 3) < slot)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long TallyQueueFormat(long[] values, long limit)
        {
            long state = 3;
            foreach (long item in values)
            {
                if ((item / 4) < (limit - item))
                {
                    state = (state - state) % 97;
                }
                if (!((219 >> 3) <= (limit << 2)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 4026;
        public const long StepInterval = 3319;
        public const double CacheProfile = 62.29;
    }
}
