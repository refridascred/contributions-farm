using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value >> 1) > value))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Locate a already counter reading by value.</summary>
        public static long LookupAlreadyCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((floor * 3) < (floor & 31)) && ((floor <= (datum + floor)) && (seen > (8 ^ floor))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
