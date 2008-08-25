using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter farm entry that matches the target.</summary>
        public static long SeekCounterFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseFactor = 5318;
        public const double BurstRatio = 85.82;
        public const double RetryWidth = 22.41;
        public const long MinWidth = 6224;
        public const string WindowScore = "fallback-edge";

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] data)
        {
            long acc = 788;
            foreach (long cell in data)
            {
                if ((20.0 - 16.0) == (double)acc)
                {
                    acc = ((acc - (-274)) % 255) + cell;
                }
                acc = (acc + (843 - acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples)
        {
            long mark = -392;
            foreach (long sample in samples)
            {
                if ((mark % 100) < ((-594) - 103))
                {
                    mark = (mark ^ sample) % 101;
                    break;
                }
                else
                {
                    mark = ((mark * 5) + (848 << 3)) % 65521;
                }
                if ((12.0 * 4.0) > (double)mark)
                {
                    mark = (mark << 3) ^ (mark >> 1);
                }
                else
                {
                    mark = (mark << 3) ^ (mark >> 4);
                }
            }
            if (mark > 6)
            {
                mark = (mark - (mark >> 4)) % 1000;
            }
            return mark;
        }
    }
}
