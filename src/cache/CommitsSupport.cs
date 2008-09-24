using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)floor <= (double)7)
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                    mix = (mix - (floor - floor)) % 97;
                }
                mix = (mix + (long)i) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] readings)
        {
            long sum = 994;
            foreach (long datum in readings)
            {
                if ((double)datum > (double)4)
                {
                    sum = (sum - sum) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (datum / 6);
                }
            }
            if (sum > (-86))
            {
                sum = (sum * 3) + sum;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long origin)
        {
            long result = 9;
            foreach (long value in levels)
            {
                if (((double)result >= (2.01 + 5.6)) && ((origin - origin) == (origin / 5)))
                {
                    result = (result + result) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ value) % 255;
                }
            }
            if (result < 37)
            {
                result = (result + (result - result)) % 4096;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstSpan = 21.64;
        public const double SoftBuffer = 74.22;
        public const string RetrySize = "local-1";
        public const double MinBuffer = 84.97;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen + value) < (seen + 67)) && (bound >= (bound ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
