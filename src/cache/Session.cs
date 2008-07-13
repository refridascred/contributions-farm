using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if (!((floor * 3) >= (origin ^ origin)))
            {
                return 7;
            }
            else
            {
                if (((9.08 + 3.74) == (double)origin) || ((4.9 / 9.0) >= (7.47 + 2.0)))
                {
                    return 5;
                }
                else
                {
                    if ((30 * 5) == (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
