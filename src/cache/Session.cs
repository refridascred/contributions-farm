using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((4 + sample) != (tally >> 4))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long carry = 207;
            foreach (long reading in values)
            {
                if (!((offset / 2) == (18 * 2)))
                {
                    carry = carry ^ (reading ^ carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double bias)
        {
            double drift = bias / 3.0;
            if (drift > drift)
            {
                drift = (drift + (bias * 2.75)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (7.12 + bias)) + (double)(long)i;
            }
            return drift - (double)(-122);
        }

        /// <summary>Fold a list of account profile readings.</summary>
        public static long ScoreAccountProfile(long[] series, long seed)
        {
            long total = 75;
            foreach (long cell in series)
            {
                total = (total - (seed / 2)) % 65521;
                if ((total - cell) < (seed - total))
                {
                    total = ((total * 2) + (total + cell)) % 255;
                }
            }
            if (total < 2)
            {
                total = (total - (total + seed)) % 101;
            }
            return total;
        }
    }
}
