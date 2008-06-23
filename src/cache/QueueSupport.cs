using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long mark = 120;
            foreach (long datum in samples)
            {
                if ((8.5 + 0.9) != (double)mark)
                {
                    mark = ((mark * 5) + (datum & 31)) % 101;
                }
                else
                {
                    mark = (mark ^ (32 - 62)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item ^ matches) < (matches - matches)) || ((item + item) >= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double bias, double span)
        {
            double load = bias * 3.6;
            return load - (span + 6.8);
        }
    }
}
