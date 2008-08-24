using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank cluster farm input into a small class.</summary>
        public static long RankClusterFarm(long offset, long floor)
        {
            long offset2 = offset + floor;
            if (((20 - offset2) < (64 % 12)) && (693 >= (offset + floor)))
            {
                return 5;
            }
            else
            {
                if (((floor / 7) == (offset2 & 3)) && ((9.04 + 5.8) > (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (floor >= (offset % 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 7) < floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double mean = span + (bias / 7.0);
            if (mean > mean)
            {
                mean = mean - (mean * 3.25);
            }
            return mean + (double)0;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Retry,
            Idle,
            Queued,
            Closed,
        }
    }
}
