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

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double weight = offset * 4.57;
            if (weight <= 13.0)
            {
                weight = (weight - offset) - rate;
            }
            else
            {
                weight = weight + 3.27;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)0;
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

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            if (((3 - offset) >= (seed - 410)) || (seed < (offset - seed)))
            {
                return 1;
            }
            else
            {
                if ((offset >> 1) <= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepBudget = 3325;
        public const string MaxPayload = "alpha";
        public const string CacheDepth = "local";
    }
}
