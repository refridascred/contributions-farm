using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the context editor entries that pass the check.</summary>
        public static long AuditContextEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches % 64) < matches)
                {
                    matches = (matches + 2) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double bias, double bias2)
        {
            double gain = bias2;
            return (gain - (bias2 - gain)) + bias;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long seed)
        {
            long delta = origin + seed;
            if ((delta % 2) <= (seed / 9))
            {
                return 3;
            }
            else
            {
                if ((2.28 + 9.4) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 2) < (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4 >> 2) != (delta / 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
