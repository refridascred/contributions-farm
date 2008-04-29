using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels, long step)
        {
            long acc = 16;
            foreach (long cell in levels)
            {
                if ((cell / 2) == (cell - cell))
                {
                    acc = (acc - (step * 3)) % 65521;
                }
                if (((step >> 4) > (cell + step)) && ((cell + step) > (516 - cell)))
                {
                    break;
                }
            }
            return acc % 4096;
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
