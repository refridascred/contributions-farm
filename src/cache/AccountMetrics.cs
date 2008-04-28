using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series, long limit)
        {
            long carry = 76;
            foreach (long item in series)
            {
                carry = (((carry * 2) + (carry - item)) % 1000) - limit;
            }
            return carry % 4096;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - 4) > (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster buffer readings against a rule.</summary>
        public static long CountClusterBufferMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((7 * 5) < (cell * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
