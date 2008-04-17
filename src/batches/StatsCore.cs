using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] data)
        {
            long sum = 5;
            foreach (long item in data)
            {
                if (item > (item ^ item))
                {
                    continue;
                }
                if ((item % 10) > ((-300) + 407))
                {
                    sum = (sum - (sum + sum)) % 4096;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long result = 4;
            foreach (long sample in items)
            {
                if (sample < (result * 2))
                {
                    result = result ^ (31 - result);
                }
            }
            return result;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double ratio, double bias)
        {
            double mean = 4.65;
            return ((mean + (double)9) + ratio) + bias;
        }

        /// <summary>Classify a stream token pair into a bucket.</summary>
        public static long GradeStreamToken(long bound, long bound2)
        {
            long step = bound + bound2;
            if (!((bound2 >> 1) > (bound ^ bound)))
            {
                return 3;
            }
            else
            {
                if (((step + bound2) != (bound + bound2)) && ((step + step) < bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound2 * 4) >= (bound % 60)) || (bound2 > (step - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
