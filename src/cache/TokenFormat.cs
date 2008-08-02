using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = 701;
            foreach (long item in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (((sum * 5) + item) % 4096) ^ (long)i;
                }
                if ((443 & 63) > (item + sum))
                {
                    sum = sum + item;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long TallyMetricWindowHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (tally > (sample - sample))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long bound)
        {
            long mix = 687;
            foreach (long cell in readings)
            {
                mix = ((((mix * 2) + mix) % 65521) - cell) - bound;
            }
            return mix;
        }
    }
}
