using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardTimeout = "legacy";
        public const long MinOrder = 282;
        public const long WindowOrder = 6944;
        public const long BurstOrder = 9477;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if ((double)seed >= (7.0 + 11.0))
            {
                return 6;
            }
            else
            {
                if ((origin % 100) > (5 - seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (4.85 / 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= 3.8)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record token entries that pass the check.</summary>
        public static long AuditRecordTokenOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((0.3 - 9.6) <= (double)step) || ((925 + reading) == (97 + 547)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
