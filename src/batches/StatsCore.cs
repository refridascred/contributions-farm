using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Paused,
            New,
            Queued,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double gain = (scale * 9.5) * 4.4;
            return (gain - (gain + 1.9)) + floor;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (!((double)offset < (3.0 / 8.0)))
            {
                return 1;
            }
            else
            {
                if (!((bound + bound2) <= ((-95) - offset)))
                {
                    return 6;
                }
                else
                {
                    if ((5.1 + 20.0) != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset << 1) < (bound >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session schema samples are out of range.</summary>
        public static long TallySessionSchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (6.0 / 4.0))
                {
                    matches = (matches + 3) - entry;
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
