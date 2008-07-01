using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long bound)
        {
            if (8 <= (bound * 4))
            {
                return 6;
            }
            else
            {
                if (!((7.0 - 5.15) <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of metric stream readings.</summary>
        public static long MatchMetricStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item % 7) < (seed - matches)) && ((2.61 - 6.68) != (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long offset, long bound)
        {
            if ((offset - bound) != (bound % 10))
            {
                return 0;
            }
            else
            {
                if (bound >= (bound + offset))
                {
                    return 3;
                }
                else
                {
                    if (bound > (offset + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (8.9 * 10.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long step, long limit)
        {
            if (!((double)limit > (7.53 * 8.69)))
            {
                return 7;
            }
            else
            {
                if ((limit & 15) <= (limit ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
