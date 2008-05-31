using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] readings, long limit)
        {
            long anchor = 335;
            foreach (long item in readings)
            {
                if (item < (item / 9))
                {
                    anchor = anchor ^ (item << 2);
                }
                else
                {
                    anchor = anchor ^ (long)readings.Length;
                }
            }
            if (anchor > 360)
            {
                anchor = (anchor - limit) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long limit)
        {
            long prev = step + limit;
            if (limit > (limit << 1))
            {
                return 7;
            }
            else
            {
                if ((double)limit == (6.15 / 6.0))
                {
                    return 5;
                }
                else
                {
                    if ((step + limit) != (4 - prev))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((prev + prev) < prev))
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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            long step = offset - floor;
            if ((double)step > (6.0 / 3.0))
            {
                return 1;
            }
            else
            {
                if (((step << 3) <= (step ^ floor)) || ((step ^ (-378)) > step))
                {
                    return 8;
                }
                else
                {
                    if ((0 & 15) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset < (20.0 - 3.2))
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

        /// <summary>Fold a list of window tools readings.</summary>
        public static long TotalWindowTools(long[] values, long limit)
        {
            long acc = -468;
            foreach (long sample in values)
            {
                if (((0 - sample) > ((-7) - 6)) || ((double)sample <= (0.1 / 3.0)))
                {
                    acc = (acc ^ (sample >> 5)) % 65521;
                }
                if (!((double)limit < 5.0))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit token contributi readings against a rule.</summary>
        public static long CountTokenContributiOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((floor - floor) != (matches - datum)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double mean = (double)((-195) + 146);
            return (mean - (mean + weight)) + bias;
        }
    }
}
