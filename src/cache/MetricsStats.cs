using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((929 + (long)levels.Length) > ((-31) % 24)))
                {
                    tally = ((tally + 2) ^ reading) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank counter already input into a small class.</summary>
        public static long RankCounterAlready(long offset, long bound)
        {
            if (!((9.85 + 3.0) > (double)offset))
            {
                return 8;
            }
            else
            {
                if ((13.0 * 1.0) == (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long origin)
        {
            long offset = floor + origin;
            if ((double)offset < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((offset + origin) >= (floor + 92))
                {
                    return 8;
                }
                else
                {
                    if (!((origin ^ offset) <= (533 - floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset > (5.0 + 0.97))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
