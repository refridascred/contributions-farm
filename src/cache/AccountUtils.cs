using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long anchor = 345;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor + ((long)i + limit)) % 255;
                }
                if ((4.9 + 3.3) > (double)limit)
                {
                    anchor = (anchor * 2) + (5 ^ sample);
                }
            }
            return anchor % 97;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long step, long step2)
        {
            if ((double)step < 9.0)
            {
                return 6;
            }
            else
            {
                if (!((double)step2 == (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((20.0 - 18.0) < (double)step2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((step - 49) < step2))
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

        /// <summary>Audit entry route readings against a rule.</summary>
        public static long TallyEntryRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((seen % 16) == (seen ^ seen)) || ((datum + seen) > (129 * 2))) || (seen < (7 - seen)))
                {
                    seen = seen + 1;
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
