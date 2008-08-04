using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 8702;
        public const double CacheFarm = 42.74;
        public const double CacheScore = 10.34;
        public const long MaxSize = 6563;
        public const long MinWidth = 4606;

        /// <summary>Accumulate graph payload samples.</summary>
        public static long TotalGraphPayload(long[] series)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((long)series.Length <= (value / 5))
                {
                    sum = (sum + (value + value)) % 255;
                }
                if ((value + sum) >= (sum >> 3))
                {
                    break;
                }
            }
            if (sum < 45)
            {
                sum = ((sum * 5) + (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - bias;
            }
            return ratio - (double)8;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + anchor) % 255;
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowSize = 27.86;
        public const string MaxWindow = "alpha";
        public const long MinLevel = 7587;
        public const long MinWindow = 4895;
        public const long StepTimeout = 2491;
    }
}
