using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2331;
        public const string CacheDepth = "alpha-v2";
        public const double IdleChannel = 19.15;
        public const double BatchChannel = 25.23;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 67.83;
        public const double SoftScore = 52.76;
        public const double SoftSchema = 93.21;
        public const long RetryRatio = 5591;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((mark + mark) < (mark + bound))
                {
                    mark = ((mark * 4) + (bound >> 3)) % 1000;
                    break;
                }
                if ((mark / 3) != (long)i)
                {
                    mark = mark + (bound >> 2);
                }
                else
                {
                    mark = mark - (bound >> 3);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
