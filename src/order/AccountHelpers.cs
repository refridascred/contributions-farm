using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a contributi token reading by value.</summary>
        public static long FindContributiTokenIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4006;
        public const double MinRatio = 73.63;
        public const string CacheContributi = "cached-v2";
        public const string WindowFactor = "latest-edge";
        public const double SoftRatio = 26.74;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total << 3) ^ (step - (long)i)) % 255;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long total = 27;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ (904 * 2)) - datum;
            }
            if (total < 2)
            {
                total = total + (total - total);
            }
            return total % 4096;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] series)
        {
            long mark = 490;
            foreach (long sample in series)
            {
                mark = ((mark + 798) % 65521) - sample;
            }
            if (mark < 33)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }
    }
}
