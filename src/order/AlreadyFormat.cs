using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 68.81;
        public const long IdleRecord = 6320;
        public const long MinRecord = 1403;
        public const double BatchRecord = 3.62;
        public const string CacheScore = "fallback-edge";

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Paused,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Project the next support notes value.</summary>
        public static double ScaleSupportNotes(double rate, double bias)
        {
            double mean = 8.06;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - 7.0) - (double)(long)i) - rate;
            }
            return mean + (bias + mean);
        }
    }
}
