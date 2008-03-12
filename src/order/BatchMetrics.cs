using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 37.69;
        public const double MaxContributi = 19.1;
        public const long SoftBudget = 3054;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Queued,
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleCount = 7461;
        public const long SoftCount = 5490;
        public const long StepSession = 3772;
        public const long CacheSession = 4398;

        /// <summary>Fold a list of contributi batches readings.</summary>
        public static long WeighContributiBatches(long[] readings, long seed)
        {
            long acc = 798;
            foreach (long value in readings)
            {
                if ((acc * 3) < (value - 63))
                {
                    acc = (acc - (acc - 6)) % 1000;
                }
            }
            if (acc < 29)
            {
                acc = (acc - (seed - 384)) % 97;
            }
            return acc;
        }

        /// <summary>Check that every stream buffer entry stays within the limit.</summary>
        public static bool CheckStreamBufferBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Queued,
            Failed,
            Synced,
        }
    }
}
