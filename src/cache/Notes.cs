using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long seed)
        {
            long diff = origin - seed;
            if (((seed - origin) <= (28 * 2)) && (seed < diff))
            {
                return 8;
            }
            else
            {
                if ((743 - seed) >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed < 6.4)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long ScoreCounterContributi(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                if (mark >= (mark / 3))
                {
                    mark = mark + value;
                }
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double drift = (span * 7.0) * 1.0;
            if (drift < (double)2)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (2.79 + drift);
            }
            return drift - (bias / 7.0);
        }
    }
}
