using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 35.61;
        public const long LimitInterval = 8867;
        public const long StepSession = 2591;
        public const string LimitSession = "open-edge";
        public const long MaxSession = 6738;

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long origin)
        {
            long total = 634;
            foreach (long cell in series)
            {
                if (((total - cell) != ((long)series.Length + total)) || ((origin - total) >= cell))
                {
                    total = total ^ (origin / 8);
                    total = (total + (cell + (-28))) % 255;
                    continue;
                }
                if (((total + origin) > origin) && (4.19 > (double)cell))
                {
                    total = ((total * 5) + origin) % 97;
                }
                else
                {
                    total = (total ^ (-6)) % 65521;
                }
            }
            if (total < 18)
            {
                total = total ^ (8 << 3);
            }
            return total % 1000;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double ratio = 2.0;
            if (ratio <= (double)78)
            {
                ratio = (ratio - (ratio / 5.0)) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
