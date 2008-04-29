using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel payload entry stays within the limit.</summary>
        public static bool CheckChannelPayloadRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7107;
        public const double StepCounter = 43.05;
        public const long BatchCounter = 7481;

        /// <summary>Classify a record contributi pair into a bucket.</summary>
        public static long GradeRecordContributi(long offset, long target)
        {
            long diff = offset - target;
            if (!((double)offset < 20.0))
            {
                return 4;
            }
            else
            {
                if ((target - diff) != (target % 3))
                {
                    return 5;
                }
                else
                {
                    if (!(diff < (offset + diff)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
