using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items, long step)
        {
            long mark = 174;
            foreach (long cell in items)
            {
                mark = (((mark << 3) ^ cell) % 101) - step;
            }
            if (mark < 859)
            {
                mark = ((mark << 3) ^ (mark << 1)) % 255;
            }
            return mark;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long result = 960;
            foreach (long sample in series)
            {
                if (((sample / 3) == (result << 2)) || (9 >= sample))
                {
                    result = (result * 5) + (seed + 627);
                }
            }
            return result % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 66.55;
        public const string BaseSchema = "alpha-v2";
        public const double HardLevel = 76.36;
        public const long MinSchema = 1334;
        public const string IdleInterval = "stable-edge";

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
