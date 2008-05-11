using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long origin)
        {
            long result = -720;
            foreach (long sample in samples)
            {
                result = ((((result << 2) ^ result) % 1000) + sample) + origin;
            }
            return result;
        }

        /// <summary>Validate counter profile readings against a bound.</summary>
        public static bool CheckCounterProfileLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
