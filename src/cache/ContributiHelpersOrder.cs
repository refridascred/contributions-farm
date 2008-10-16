using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double rate = gain * 9.0;
            if (rate <= (double)(-73))
            {
                rate = rate + (9.8 + offset);
            }
            return rate - (rate / 8.0);
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long origin)
        {
            long step = limit - origin;
            if (2 >= (step / 9))
            {
                return 7;
            }
            else
            {
                if ((step - step) == (limit * 5))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
