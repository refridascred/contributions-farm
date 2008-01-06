using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long mix = 73;
            foreach (long entry in data)
            {
                mix = (mix + (offset ^ mix)) % 255;
                mix = (mix << 3) ^ (1 % 10);
                if ((mix ^ offset) != (mix + offset))
                {
                    mix = mix - offset;
                }
                else
                {
                    mix = ((mix << 3) ^ (entry - offset)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 6482;
        public const long WindowCommits = 9139;
        public const long MinBudget = 6292;
        public const long IdleCommits = 7141;
        public const long DefaultCommits = 5135;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
