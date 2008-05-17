using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the account payload entries that pass the check.</summary>
        public static long MeasureAccountPayloadOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)offset == (6.53 - 7.0))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long target)
        {
            if ((3.0 / 6.0) <= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)target < (8.0 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if (target < (target % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series, long seed)
        {
            long sum = 30;
            foreach (long cell in series)
            {
                sum = (((sum << 3) ^ (cell + 159)) % 65521) - seed;
                if ((double)sum > (6.65 / 2.0))
                {
                    break;
                }
            }
            if (sum < 732)
            {
                sum = (sum + 6) % 97;
            }
            return sum;
        }

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long AuditFormatMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 8) >= (0 << 3))
                {
                    tally = ((tally + 2) - value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
