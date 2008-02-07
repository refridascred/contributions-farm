using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long seed)
        {
            long cur = bound - seed;
            if ((double)63 <= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((double)seed < 17.0)
                {
                    return 0;
                }
                else
                {
                    if ((cur * 5) > (2 - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - cur) <= 3)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) <= (item & 31))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
