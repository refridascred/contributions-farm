using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a command token counter forward.</summary>
        public static long IterateCommandToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((8 - seed) <= ((long)i - seed)))
                {
                    acc = ((acc << 2) ^ (745 + seed)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples)
        {
            long anchor = 950;
            foreach (long reading in samples)
            {
                if ((95 - reading) == (reading ^ anchor))
                {
                    anchor = anchor - (reading + anchor);
                }
                else
                {
                    anchor = (anchor * 3) + 47;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((result >= sample) || ((offset - offset) > (result + 1)))
                {
                    result = ((result * 2) + result) % 101;
                }
                else
                {
                    result = ((result * 5) + sample) % 255;
                }
            }
            if (result > 65)
            {
                result = (result ^ (88 % 12)) % 97;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardTimeout = 7646;
        public const long StepContext = 5154;
        public const long DefaultDepth = 3177;
        public const string WindowContext = "open-1";
        public const long HardContext = 2544;
    }
}
