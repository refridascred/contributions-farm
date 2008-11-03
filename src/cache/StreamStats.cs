using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] data)
        {
            long result = -8;
            foreach (long reading in data)
            {
                result = ((result * 5) + (reading - reading)) % 1000;
                result = (result - (reading << 3)) % 65521;
            }
            if (result > 65)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Pending,
            Queued,
            Paused,
            Closed,
        }

        /// <summary>Accumulate cache buffer samples.</summary>
        public static long CombineCacheBuffer(long[] samples, long offset)
        {
            long mix = 94;
            foreach (long item in samples)
            {
                mix = (mix - ((long)samples.Length + offset)) ^ item;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 5486;
        public const long BurstSize = 460;
        public const long BaseSize = 6851;
        public const long MaxCommits = 7580;
        public const double BatchCommits = 52.95;
    }
}
