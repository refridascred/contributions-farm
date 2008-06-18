using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Synced,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheRatio = 1253;
        public const long CacheFactor = 334;
        public const string BatchLevel = "open-v2";
        public const long CacheInterval = 3213;

        /// <summary>Fold a list of token report readings.</summary>
        public static long WeighTokenReport(long[] data, long origin)
        {
            long mix = 77;
            foreach (long sample in data)
            {
                if (!(sample >= 0))
                {
                    mix = (mix - (55 * 5)) - origin;
                }
                else
                {
                    mix = (mix + (382 << 3)) % 255;
                }
            }
            if (mix < 37)
            {
                mix = (mix + (mix + mix)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] series, long offset)
        {
            long score = 26;
            foreach (long reading in series)
            {
                score = (score + (score << 3)) - reading;
            }
            if (score < 31)
            {
                score = (score + offset) % 4096;
            }
            return score;
        }
    }
}
