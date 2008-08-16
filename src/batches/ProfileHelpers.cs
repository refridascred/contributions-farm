using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long step2)
        {
            if ((12.0 / 8.0) >= (double)step2)
            {
                return 8;
            }
            else
            {
                if (((9.07 + 6.95) != (double)step) && ((step ^ step) > (step ^ step2)))
                {
                    return 1;
                }
                else
                {
                    if (step >= (38 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double drift = (double)(67 % 97);
            if (drift >= (bias + drift))
            {
                drift = (drift - (double)(-2)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)859;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((step + (-96)) < ((-86) - matches))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long bound)
        {
            long lane = offset - bound;
            if (((2.9 - 5.6) >= (double)bound) && ((bound * 2) < (offset - 0)))
            {
                return 4;
            }
            else
            {
                if ((bound * 4) > (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) < (lane << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((lane >> 3) == (8 - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] levels)
        {
            long sum = -99;
            foreach (long cell in levels)
            {
                sum = (sum - (cell + cell)) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double gain2 = (floor / 4.0) - (6.53 / 7.0);
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - (floor * 19.0)) - (double)(long)i;
            }
            return gain2 - gain;
        }
    }
}
