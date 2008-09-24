using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 6;
            }
            else
            {
                if ((seed % 24) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((15.0 + 2.52) == (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long TallyChecksLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((cell + cell) != (tally - cell)) && ((5 + tally) < (tally + 504))) && (((double)cell >= (6.02 + 2.0)) || (((-37) + 0) >= (tally ^ tally))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 61;
        public const double BurstTools = 84.38;
        public const long HardTools = 2370;
        public const long LimitTools = 6924;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long bound)
        {
            if ((433 - 1) == (bound * 2))
            {
                return 6;
            }
            else
            {
                if ((15.0 - 2.99) == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor << 2) >= ((-282) * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.52 / 7.0) < (double)floor) || ((floor - floor) == (bound + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Closed,
            Synced,
            Locked,
        }
    }
}
