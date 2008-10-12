using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5985;
        public const long CacheSpan = 8164;
        public const long MaxContributi = 4640;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches >> 2) > (945 + datum))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batches queue pair into a bucket.</summary>
        public static long GradeBatchesQueue(long step, long step2)
        {
            if (((-61) % 24) > (step * 4))
            {
                return 2;
            }
            else
            {
                if (((step << 3) >= (step * 2)) || ((step2 ^ step2) >= (step % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 >> 2) >= (step2 / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(step2 >= (3 - step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(((value + value) >= value) && ((value + value) >= value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
