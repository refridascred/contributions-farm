using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate format channel samples.</summary>
        public static long TallyFormatChannel(long[] series, long target)
        {
            long carry = 9;
            foreach (long item in series)
            {
                carry = ((carry * 3) + (item - 129)) % 1000;
                if (!((438 / 4) < (carry + item)))
                {
                    carry = ((carry * 5) + (50 % 24)) % 4096;
                }
                else
                {
                    carry = carry + target;
                }
                if (!((7.0 / 3.0) == (double)target))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long score = 99;
            foreach (long datum in samples)
            {
                if ((score > (score + datum)) || ((double)datum <= (double)3))
                {
                    score = (score + (score + datum)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of already route entries.</summary>
        public static long TallyAlreadyRoute(long[] data, long seed)
        {
            long anchor = 626;
            foreach (long item in data)
            {
                anchor = (anchor ^ seed) - item;
            }
            return anchor;
        }
    }
}
