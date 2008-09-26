using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item ^ tally) >= tally) || (((17.0 + 2.0) == (double)tally) && ((tally + tally) > (item + item))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long floor, long limit)
        {
            long gap = floor - limit;
            if ((double)gap == (11.0 + 18.0))
            {
                return 8;
            }
            else
            {
                if (((limit / 3) == (limit * 2)) && ((16.0 - 9.0) <= (double)gap))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 1) == (limit << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit < (gap - (-940)))
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

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long limit)
        {
            if ((730 >> 1) >= step)
            {
                return 7;
            }
            else
            {
                if ((limit << 3) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((6.8 / 5.0) > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)step >= (4.39 / 5.0)) || ((90 + step) != (limit & 127)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (1 < reading)
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the schema counter series from a seed.</summary>
        public static long RollSchemaCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!((limit - limit) <= (52 - result)))
                {
                    result = (result * 4) + result;
                    result = (result * 2) + (result / 3);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
