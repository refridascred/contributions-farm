using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate farm record samples.</summary>
        public static long DigestFarmRecord(long[] samples, long offset)
        {
            long state = 12;
            foreach (long cell in samples)
            {
                state = ((state - offset) % 255) - cell;
            }
            if (state > 866)
            {
                state = state ^ (-904);
            }
            return state % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 98.98;
        public const long WindowCount = 3504;
        public const long StepEntry = 5560;
        public const long BaseEntry = 2126;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) < hits)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count the order context entries that pass the check.</summary>
        public static long MeasureOrderContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((3.35 / 7.0) > (double)entry) || ((entry + 66) > (entry + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long limit)
        {
            if ((floor + limit) < (floor - (-8)))
            {
                return 8;
            }
            else
            {
                if (((525 + limit) <= (floor >> 3)) && ((double)4 == (double)floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 60) != (floor - 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor << 3) >= (limit >> 5)) || ((limit % 100) >= (limit - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] series, long limit)
        {
            long anchor = 78;
            foreach (long item in series)
            {
                anchor = ((anchor ^ (57 << 3)) + item) + limit;
            }
            return anchor;
        }
    }
}
