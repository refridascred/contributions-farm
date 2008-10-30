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

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double drift = 14.0;
            if (drift < (bias / 5.0))
            {
                drift = drift - (bias / 7.0);
            }
            else
            {
                drift = drift - (bias + rate);
            }
            return drift - (rate / 6.0);
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] data)
        {
            long anchor = 283;
            foreach (long value in data)
            {
                if ((0.9 * 10.0) != (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (value & 63)) % 4096;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor << 3) ^ (anchor ^ anchor);
            }
            return anchor % 1000;
        }
    }
}
