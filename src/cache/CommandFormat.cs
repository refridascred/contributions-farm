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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((limit + acc) == (long)i)
                {
                    acc = (acc ^ (395 + 180)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double scale = 7.6 * 3.5;
            if (scale < (gain / 3.0))
            {
                scale = (scale - 7.67) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (1.5 / 7.0);
        }
    }
}
