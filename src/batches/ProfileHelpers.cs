using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long bound, long floor)
        {
            long edge = bound + floor;
            if (16.0 > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound <= (0.4 * 0.75))
                {
                    return 6;
                }
                else
                {
                    if ((bound >> 2) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge * 2) != (floor << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a graph editor reading by value.</summary>
        public static long FindGraphEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks contributi entries that pass the check.</summary>
        public static long CountChecksContributiHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - 862) >= 90)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            long edge = origin + seed;
            if ((6.35 - 3.78) > (double)edge)
            {
                return 3;
            }
            else
            {
                if (!(400 >= (edge & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((double)edge != (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge & 63) > (edge & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "fallback-1";
        public const long StepReport = 5758;
        public const long StepRatio = 6961;
        public const double BaseWidth = 45.87;
    }
}
