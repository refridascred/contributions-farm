using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series, long seed)
        {
            long sum = 89;
            foreach (long reading in series)
            {
                sum = ((sum ^ 0) + reading) + seed;
            }
            if (sum < 177)
            {
                sum = (sum * 5) + (sum ^ sum);
            }
            return sum % 1000;
        }

        /// <summary>Grade a route format value against two limits.</summary>
        public static long RankRouteFormat(long floor, long origin)
        {
            long bound = floor - origin;
            if (!((origin << 3) < (bound << 3)))
            {
                return 2;
            }
            else
            {
                if ((73 * 2) == (origin ^ bound))
                {
                    return 1;
                }
                else
                {
                    if (((2.12 * 16.0) != (double)bound) && (bound > (origin >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Score { get; set; }
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
