using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a already profile figure with a bias.</summary>
        public static double ScaleAlreadyProfile(double gain, double bias)
        {
            double scale = 3.88;
            if (scale < gain)
            {
                scale = (scale - scale) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)633) - (double)(long)i;
            }
            return scale - (double)794;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5899;
        public const double BaseTools = 27.71;
        public const long BurstTools = 1291;
        public const double MaxTools = 0.89;
        public const long RetryTools = 878;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 4;
            foreach (long entry in readings)
            {
                if (!((553 + carry) >= 436))
                {
                    carry = ((carry ^ (9 / 4)) % 65521) + entry;
                }
                else
                {
                    carry = ((carry * 3) + 267) % 97;
                }
            }
            if (carry > (-4))
            {
                carry = ((carry * 2) + (carry - carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 3) <= (matches >> 1)) || !((floor * 4) < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the route graph series from a seed.</summary>
        public static long RollRouteGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 3) ^ (acc * 5)) % 1000;
                if ((seed + 3) < (acc + seed))
                {
                    acc = (acc * 3) + seed;
                    acc = (acc - ((long)i + 167)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
