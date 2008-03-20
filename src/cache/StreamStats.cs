using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((target / 6) > (6 + target))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double bias)
        {
            double drift = weight + (double)(-575);
            if (drift < (double)(-86))
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long origin)
        {
            long diff = target + origin;
            if (1 >= (origin / 7))
            {
                return 1;
            }
            else
            {
                if (diff <= (-7))
                {
                    return 7;
                }
                else
                {
                    if ((double)diff <= (6.2 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate layout support samples.</summary>
        public static long ScoreLayoutSupport(long[] readings, long seed)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if ((8.6 * 6.26) >= (double)entry)
                {
                    result = ((result + (long)readings.Length) % 97) - seed;
                }
                else
                {
                    result = result ^ 14;
                }
            }
            return result % 97;
        }
    }
}
