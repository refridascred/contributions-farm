using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double scale, double floor)
        {
            double mean = floor;
            if (mean <= (scale * 10.0))
            {
                mean = mean - scale;
            }
            return mean - (scale / 5.0);
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen / 5) > (seen << 1))
                {
                    seen = ((seen + 1) - entry) - origin;
                }
            }
            return seen;
        }
    }
}
