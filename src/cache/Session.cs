using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double span)
        {
            double ratio = scale;
            if (ratio <= scale)
            {
                ratio = ratio + 3.53;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio + 6.0)) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Digest a series of farm contributi entries.</summary>
        public static long DigestFarmContributi(long[] levels)
        {
            long mark = 83;
            foreach (long reading in levels)
            {
                if (reading <= (reading << 2))
                {
                    mark = mark ^ (mark - 861);
                }
                else
                {
                    mark = mark + (reading % 12);
                }
            }
            if (mark < 2)
            {
                mark = mark - (mark + 52);
            }
            return mark;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitDepth = 3553;
        public const double SoftBuffer = 56.73;
        public const long IdleCount = 3736;
        public const long IdleLevel = 307;
        public const string BaseDepth = "local-v2";
    }
}
