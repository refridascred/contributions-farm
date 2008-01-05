using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] data)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                if (!((reading + 76) != (2 & 255)))
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (acc + 695)) % 255;
                }
                if ((4.6 - 4.53) < (double)reading)
                {
                    acc = ((acc << 3) ^ ((long)data.Length + acc)) % 4096;
                }
                if ((7.1 + 6.3) != (double)acc)
                {
                    break;
                }
            }
            if (acc < 58)
            {
                acc = ((acc * 5) + (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels, long step)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                if ((604 & 31) < (entry + entry))
                {
                    mark = mark + 7;
                    mark = mark - entry;
                }
                mark = ((mark << 3) ^ 3) % 4096;
            }
            if (mark > 75)
            {
                mark = (mark - (step / 6)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchWidth = 7.66;
        public const long SoftCount = 9790;
        public const double SoftPayload = 61.0;
    }
}
