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

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Stale,
            Failed,
            Idle,
            New,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long target, long offset)
        {
            long offset2 = target ^ offset;
            if ((target % 97) > (offset2 - (-30)))
            {
                return 1;
            }
            else
            {
                if ((10.0 + 5.0) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (3.7 * 2.91))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (offset2 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
