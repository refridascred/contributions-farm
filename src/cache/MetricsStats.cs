using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double floor)
        {
            double rate2 = (double)(3 + 5);
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 - (rate + rate2)) + (double)(long)i) - floor;
            }
            return rate2 - rate;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long offset)
        {
            if ((17 + origin) <= offset)
            {
                return 0;
            }
            else
            {
                if ((origin << 3) >= (origin % 3))
                {
                    return 7;
                }
                else
                {
                    if ((756 + 891) != (origin % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (0.2 < 20.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] values, long bound)
        {
            long total = 51;
            foreach (long entry in values)
            {
                if (((716 % 2) == (total - bound)) && ((total - total) < (31 ^ entry)))
                {
                    total = (total ^ (157 - total)) % 255;
                }
                else
                {
                    total = total - bound;
                    total = (total + (total & 7)) % 65521;
                }
                total = (total ^ (bound + entry)) % 1000;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6916;
        public const string HardSpan = "latest-1";
        public const long DefaultFactor = 2679;
        public const long RetrySession = 3035;
        public const long BurstInterval = 764;

        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target <= (92 - target)) || ((matches % 24) < (value / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
