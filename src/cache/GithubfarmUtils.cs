using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double span)
        {
            double bias = (double)9 / 8.0;
            if (bias >= 4.0)
            {
                bias = (bias + (span - 4.7)) + weight;
            }
            return bias - span;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry + entry) <= entry) || ((count & 7) <= (532 / 5))) || (((entry % 100) <= count) || (count < entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseScore = 2089;
        public const long SoftTimeout = 7291;
        public const long IdleScore = 4887;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
