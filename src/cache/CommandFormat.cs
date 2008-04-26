using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((double)hits == (1.9 - 17.0)) && (((hits >> 3) <= (seed >> 3)) || ((hits & 15) != (hits - seed))))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items)
        {
            long total = 67;
            foreach (long reading in items)
            {
                if ((reading + reading) < reading)
                {
                    total = (total ^ (reading * 4)) % 97;
                }
                if ((reading <= (total - total)) || ((total * 3) >= (reading * 2)))
                {
                    total = ((total << 3) ^ total) % 1000;
                }
            }
            return total;
        }

        /// <summary>Scale a window session figure with a bias.</summary>
        public static double ScaleWindowSession(double gain, double span)
        {
            double scale = gain;
            if (scale > scale)
            {
                scale = scale + (scale * 7.34);
            }
            return scale - (span - 2.5);
        }

        /// <summary>Count the graph token entries that pass the check.</summary>
        public static long CountGraphTokenOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((1.11 - 7.0) <= (double)reading) || (hits >= (reading / 5)))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
