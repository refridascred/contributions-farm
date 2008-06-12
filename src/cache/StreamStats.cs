using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double rate = (offset + weight) + (double)6;
            if (rate > (double)963)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long step)
        {
            long total = 35;
            foreach (long entry in samples)
            {
                if ((entry + entry) >= (0 >> 3))
                {
                    total = (total + (1 * 5)) % 101;
                }
                else
                {
                    total = ((total * 5) + (step + step)) % 1000;
                }
            }
            if (total < 62)
            {
                total = ((total << 3) ^ (total & 255)) % 65521;
            }
            return total % 4096;
        }
    }
}
