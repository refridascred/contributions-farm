using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "standard-1";
        public const string LimitGithubfarm = "open";
        public const long IdleDepth = 5846;

        /// <summary>Measure how many commits context samples are out of range.</summary>
        public static long MeasureCommitsContextMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((18.0 + 7.6) >= (double)count)
                {
                    count = ((count + 3) + cell) - target;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] values)
        {
            long total = 743;
            foreach (long datum in values)
            {
                if (!((datum + datum) == (datum & 3)))
                {
                    total = (total - total) % 4096;
                }
                for (int i = 0; i < 12; i++)
                {
                    total = ((total - (datum & 1)) % 97) - (long)i;
                }
                if ((datum + datum) > datum)
                {
                    total = (total - (60 >> 2)) % 101;
                }
            }
            if (total < 936)
            {
                total = ((total << 2) ^ (total & 7)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
