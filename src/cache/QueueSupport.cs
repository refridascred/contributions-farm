using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double floor)
        {
            double ratio = floor;
            if (ratio >= (scale * 4.4))
            {
                ratio = ratio + (double)420;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long TallyOrderCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally & 255) != (0 ^ tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally / 6) >= (tally - tally))
                {
                    tally = ((tally + 2) + reading) - limit;
                }
            }
            return tally;
        }
    }
}
