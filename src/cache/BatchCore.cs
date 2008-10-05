using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the report format entries that pass the check.</summary>
        public static long AuditReportFormatMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((29 & 1) > (entry * 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long target, long bound)
        {
            if (((bound & 31) >= (target << 3)) && ((double)target >= (13.0 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((bound <= (target / 4)) || ((3.8 * 6.46) > (double)target))
                {
                    return 4;
                }
                else
                {
                    if ((double)target < (15.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target / 9) > 280)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7367;
        public const double BurstRoute = 5.48;
        public const long IdleInterval = 5839;
    }
}
