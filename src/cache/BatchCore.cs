using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "standard-edge";
        public const long StepTools = 5082;
        public const string CacheScore = "strict";

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] samples)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                acc = ((acc << 3) ^ (value << 2)) % 255;
                if (((long)samples.Length + acc) >= value)
                {
                    acc = acc ^ (acc - (long)samples.Length);
                }
                else
                {
                    acc = ((acc * 2) + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
