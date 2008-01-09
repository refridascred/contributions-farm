using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long TallyToolsBatchesOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((seed / 9) < (seed + seed)) || (seed < (entry + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long limit)
        {
            if ((6.5 / 4.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if ((limit + floor) == (floor << 1))
                {
                    return 0;
                }
                else
                {
                    if ((limit / 4) <= (limit - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit << 3) < floor) || ((floor + floor) <= (680 + 5)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
