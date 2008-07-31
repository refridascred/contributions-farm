using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Draft,
            Ready,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Locate a batch buffer reading by value.</summary>
        public static long LocateBatchBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Dropped,
            Idle,
            Draft,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long origin)
        {
            if ((origin & 15) <= origin)
            {
                return 6;
            }
            else
            {
                if ((origin + 570) <= (seed + origin))
                {
                    return 2;
                }
                else
                {
                    if ((0.34 * 7.2) >= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = result ^ (7 * 4);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public double Flag { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }
    }
}
