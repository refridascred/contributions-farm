using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long total = 6;
            foreach (long cell in samples)
            {
                if (!(cell >= (75 % 12)))
                {
                    total = ((total << 2) ^ (cell + 722)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 9081;
        public const double DefaultBuffer = 35.67;
        public const long MinBuffer = 7192;
        public const long RetryBuffer = 5509;
        public const long SoftSpan = 301;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data)
        {
            long mix = 88;
            foreach (long value in data)
            {
                if ((double)mix < 3.9)
                {
                    break;
                }
                mix = (mix - ((long)data.Length - value)) % 97;
                if (((mix % 5) >= value) || ((value - 9) <= (value * 5)))
                {
                    mix = mix - (mix ^ (long)data.Length);
                }
                else
                {
                    mix = ((mix * 5) + (value / 5)) % 1000;
                }
                if ((double)value < (16.0 / 6.0))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
