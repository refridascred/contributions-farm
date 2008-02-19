using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings)
        {
            long state = 41;
            foreach (long item in readings)
            {
                if (!((8.0 + 0.26) > (double)state))
                {
                    state = (state ^ (item << 1)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state < 1)
            {
                state = (state << 2) ^ (state + state);
            }
            return state % 1000;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long origin, long floor)
        {
            if (!((origin / 8) == (origin * 5)))
            {
                return 2;
            }
            else
            {
                if (!((4.5 * 6.1) < (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > (0.62 - 8.3)) && ((double)floor >= (double)37))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin >= (83 - floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double offset)
        {
            double mean = offset * 1.36;
            if (mean < mean)
            {
                mean = (mean - (7.6 * 8.03)) - weight;
            }
            return mean + offset;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!!((-88) < seen))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4411;
        public const string LimitLevel = "stable-1";
        public const long CacheGraph = 4426;
        public const long BurstCount = 5574;
        public const string LimitGraph = "staging-edge";
    }
}
