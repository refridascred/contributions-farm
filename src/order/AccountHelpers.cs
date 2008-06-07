using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks batch readings against a rule.</summary>
        public static long MeasureChecksBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count == (4.0 + 15.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long offset, long floor)
        {
            if (((double)offset <= (9.0 / 5.0)) && ((offset + offset) != (offset - offset)))
            {
                return 0;
            }
            else
            {
                if (((floor << 3) >= (157 >> 3)) && ((offset ^ 4) <= (94 % 7)))
                {
                    return 7;
                }
                else
                {
                    if ((141 >> 5) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >= (floor % 97)) || ((floor & 255) != (floor * 2)))
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

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Paused,
            Closed,
            Done,
        }
    }
}
