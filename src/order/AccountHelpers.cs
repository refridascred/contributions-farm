using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + reading) < (reading << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double drift = (0.1 * 3.51) * 4.0;
            if (drift < floor)
            {
                drift = drift - (floor / 9.0);
            }
            return drift + ratio;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "staging";
        public const long WindowFactor = 1082;
        public const long CacheLevel = 4731;
        public const double LimitWindow = 60.79;
        public const double WindowInterval = 15.92;
    }
}
