using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long StepNotesToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = (result ^ offset) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] data, long offset)
        {
            long mark = 375;
            foreach (long sample in data)
            {
                if (((mark << 2) <= (offset << 2)) || ((double)sample <= 9.87))
                {
                    mark = (mark ^ (offset - offset)) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 5534;
        public const double MinRoute = 94.22;
        public const long DefaultWidth = 5605;
        public const double DefaultSize = 81.94;
        public const long HardRoute = 7234;
    }
}
