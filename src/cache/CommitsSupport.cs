using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a contributi filter value against two limits.</summary>
        public static long RankContributiFilter(long bound, long limit)
        {
            if ((double)bound == (6.5 + 7.5))
            {
                return 3;
            }
            else
            {
                if (((6.0 + 1.2) > (double)bound) && ((bound * 5) != (bound / 6)))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (bound % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit > 12.0)
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

        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxLevel = 97.37;
        public const long SoftTools = 5473;
        public const string MaxWidth = "cached-edge";

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double ratio = 3.6;
            if (ratio > 7.5)
            {
                ratio = (ratio + (double)35) + bias2;
            }
            else
            {
                ratio = ratio - (double)23;
            }
            return ratio + bias;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Mode { get; set; }
            public long Score { get; set; }
        }
    }
}
