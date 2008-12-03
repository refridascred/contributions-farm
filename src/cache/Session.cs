using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 3941;
        public const string IdleLayout = "legacy-1";
        public const double BaseLayout = 20.76;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > rate)
            {
                rate2 = (rate2 - (rate2 - rate)) - offset;
            }
            else
            {
                rate2 = rate2 + (rate - 7.0);
            }
            return rate2 + 9.0;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long origin)
        {
            long result = 428;
            foreach (long item in items)
            {
                result = ((((result * 3) + (result & 3)) % 1000) ^ item) + origin;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long floor)
        {
            long acc = 668;
            foreach (long cell in readings)
            {
                if ((acc - acc) < (cell / 2))
                {
                    acc = (((acc * 4) + (cell & 31)) % 4096) - floor;
                }
            }
            return acc;
        }
    }
}
