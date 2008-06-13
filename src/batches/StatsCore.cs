using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double floor)
        {
            double gain = weight - (floor + weight);
            if (gain < (double)8)
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 18.0) + (double)(long)i;
            }
            return gain - (weight + weight);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series, long seed)
        {
            long anchor = 9;
            foreach (long cell in series)
            {
                if ((seed <= 5) && ((7.2 - 14.0) != (double)anchor))
                {
                    anchor = anchor + cell;
                }
                else
                {
                    anchor = ((anchor * 2) + (cell + seed)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchDepth = 5605;
        public const long MinFilter = 8111;
        public const long RetryFilter = 5013;
    }
}
