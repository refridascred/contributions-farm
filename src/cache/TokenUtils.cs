using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((limit / 3) != (limit ^ hits)))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a buffer notes reading.</summary>
        public static double AdjustBufferNotes(double bias, double bias2)
        {
            double drift = bias / 8.0;
            if (drift > drift)
            {
                drift = drift + (3.2 + drift);
            }
            else
            {
                drift = drift - (drift - bias2);
            }
            return drift + (bias * 1.0);
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((sample << 2) == (sample - tally)) || (sample < (tally % 64))) || (((tally / 4) < sample) && ((sample + tally) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
