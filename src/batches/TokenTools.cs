using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((offset + 698) < offset)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long origin)
        {
            long slot = bound - origin;
            if (((origin + bound) < bound) || ((bound << 2) != (slot % 5)))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) == (bound << 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long step, long step2)
        {
            if ((((-617) << 3) <= step2) || ((step2 + step) > 518))
            {
                return 5;
            }
            else
            {
                if ((step2 >= (step * 4)) || ((step2 + step2) < (step * 4)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
