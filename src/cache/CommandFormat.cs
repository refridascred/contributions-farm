using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] data)
        {
            long result = 438;
            foreach (long sample in data)
            {
                if ((sample * 5) <= sample)
                {
                    continue;
                }
                else
                {
                    result = (result - sample) % 1000;
                }
                result = (result ^ ((long)data.Length + 26)) % 65521;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 7276;
        public const long RetryEntry = 9724;
        public const long MaxSize = 8797;
        public const double MaxEntry = 23.44;

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data, long seed)
        {
            long mix = -20;
            foreach (long item in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix ^ (item - (long)i)) % 97;
                    mix = (mix + (seed << 2)) % 65521;
                }
                if ((seed % 64) <= seed)
                {
                    mix = (mix << 2) ^ seed;
                }
                else
                {
                    mix = (mix - (item + item)) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Ready,
            Failed,
        }
    }
}
