using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] levels)
        {
            long mix = -55;
            foreach (long sample in levels)
            {
                if (!((mix - 0) == (mix & 7)))
                {
                    mix = (mix - (0 / 8)) % 255;
                }
                if ((15.0 / 9.0) <= (double)sample)
                {
                    mix = ((mix << 3) ^ mix) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 4794;
        public const long CacheCounter = 7565;
        public const long MinCounter = 469;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long MeasureSessionFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally >= (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
