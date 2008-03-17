using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long result = 34;
            foreach (long item in values)
            {
                result = ((((result * 3) + (result ^ 7)) % 101) + item) - bound;
            }
            if (result > 73)
            {
                result = (result ^ (result << 3)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Roll a profile report counter forward.</summary>
        public static long RollProfileReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (mark << 1)) % 255;
                mark = ((mark << 3) ^ (bound % 10)) % 4096;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Find the first batches queue entry that matches the target.</summary>
        public static long LocateBatchesQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
