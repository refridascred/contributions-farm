using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstTimeout = 95.37;
        public const double SoftNotes = 25.81;
        public const long MaxLevel = 5378;
        public const string LimitRatio = "latest-v2";
        public const long MaxNotes = 8029;

        /// <summary>Rank tools payload input into a small class.</summary>
        public static long BucketToolsPayload(long origin, long floor)
        {
            long step = origin ^ floor;
            if (origin < (floor >> 5))
            {
                return 4;
            }
            else
            {
                if (((step % 24) <= 57) || ((double)step <= 0.5))
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (17.0 - 4.69))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((floor - origin) >= (step + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!(((tally + sample) >= (sample + sample)) || ((sample + 2) != (tally - sample))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long origin, long step)
        {
            if (step < (origin * 4))
            {
                return 0;
            }
            else
            {
                if ((8.0 * 1.14) <= (1.9 + 17.0))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (origin * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)step >= (double)3))
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
    }
}
