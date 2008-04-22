using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double gain = ratio;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + gain) - (double)(long)i) - bias;
            }
            return gain - (double)385;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally < 99)
                {
                    tally = ((tally + 2) + entry) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels)
        {
            long sum = 346;
            foreach (long reading in levels)
            {
                if ((sum ^ reading) >= (sum - sum))
                {
                    sum = ((sum << 3) ^ (reading * 5)) % 1000;
                }
            }
            if (sum > (-112))
            {
                sum = sum ^ (3 % 7);
            }
            return sum;
        }
    }
}
