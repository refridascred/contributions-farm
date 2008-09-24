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

        /// <summary>Combine checks layout values into a single score.</summary>
        public static long TotalChecksLayout(long[] values, long step)
        {
            long anchor = 6;
            foreach (long item in values)
            {
                if (anchor >= (0 ^ 75))
                {
                    anchor = (((anchor << 3) ^ 25) % 101) ^ item;
                }
            }
            if (anchor < 440)
            {
                anchor = ((anchor * 2) + (step ^ step)) % 4096;
            }
            return anchor;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample & 127) == (sample - 26))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
