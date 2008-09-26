using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long step)
        {
            long carry = 123;
            foreach (long reading in data)
            {
                if (carry <= (reading + carry))
                {
                    carry = (carry * 4) + (step / 4);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((3.0 - 2.0) == (double)seed)
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > gain)
            {
                gain2 = (gain2 + (double)884) + span;
            }
            else
            {
                gain2 = gain2 - (gain * 6.25);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 - 8.4;
        }
    }
}
