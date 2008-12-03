using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long seed, long floor)
        {
            if (((floor % 12) == (floor << 3)) && ((floor + floor) == (seed + floor)))
            {
                return 2;
            }
            else
            {
                if ((1 + floor) == (663 ^ floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor - 9) == (5 & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (13.0 <= (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)datum < (16.0 + 1.0)) || (((double)matches <= (4.0 / 2.0)) || ((matches / 2) == (51 << 1))))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
