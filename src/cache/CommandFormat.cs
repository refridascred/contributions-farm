using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin * 2) != ((long)readings.Length >> 3))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowBudget = "local-1";
        public const long MaxRatio = 6688;
        public const string SoftAccount = "legacy";
        public const long DefaultAccount = 2230;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] items, long origin)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                if ((cell < (mix ^ cell)) || ((5.61 / 8.0) != (double)origin))
                {
                    mix = (mix - 20) % 255;
                }
            }
            if (mix > (-8))
            {
                mix = ((mix << 3) ^ (mix + (-44))) % 255;
            }
            return mix % 97;
        }
    }
}
