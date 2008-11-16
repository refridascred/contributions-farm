using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - sample) == ((long)readings.Length << 1))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long MeasureCommitsTokenHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum <= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next support schema value.</summary>
        public static double SmoothSupportSchema(double gain, double floor)
        {
            double gain2 = (double)(592 - 8);
            if (gain2 >= (floor / 3.0))
            {
                gain2 = gain2 - (floor + gain2);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + (floor - gain)) + (double)(long)i;
            }
            return gain2 - (floor / 7.0);
        }
    }
}
