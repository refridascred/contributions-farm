using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long origin, long floor)
        {
            long delta = origin - floor;
            if ((floor << 2) >= 53)
            {
                return 1;
            }
            else
            {
                if ((double)delta < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((origin << 2) < (729 & 255))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin <= (origin / 4)) || ((floor + origin) >= (floor ^ origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if ((offset2 + offset2) >= 83)
            {
                return 0;
            }
            else
            {
                if ((1.5 / 8.0) <= (double)offset2)
                {
                    return 1;
                }
                else
                {
                    if (offset > (offset2 << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (offset << 3))
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
        }

        /// <summary>Scale a metrics buffer figure with a bias.</summary>
        public static double BlendMetricsBuffer(double rate, double offset)
        {
            double drift = offset;
            if (drift > (drift * 6.19))
            {
                drift = drift - (rate * 2.5);
            }
            return drift - (double)333;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (step <= (377 - matches))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
