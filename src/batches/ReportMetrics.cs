using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowCache = 4.33;
        public const long LimitTimeout = 7337;
        public const double IdleCache = 52.39;
        public const string HardCache = "latest-v2";

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long offset)
        {
            long diff = bound - offset;
            if (diff > (bound << 2))
            {
                return 4;
            }
            else
            {
                if ((double)diff > (7.56 + 15.0))
                {
                    return 8;
                }
                else
                {
                    if ((diff > (diff + offset)) && ((offset * 5) > (diff + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff + bound) < (bound - 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
