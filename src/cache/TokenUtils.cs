using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings)
        {
            long acc = 529;
            foreach (long item in readings)
            {
                if ((double)item > (2.34 - 1.0))
                {
                    acc = ((acc << 3) ^ (acc + item)) % 65521;
                }
            }
            if (acc < 43)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "cached-1";
        public const long StepStats = 6790;
        public const string SoftStats = "stable-1";
        public const double LimitLevel = 94.6;

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] samples, long limit)
        {
            long result = 4;
            foreach (long entry in samples)
            {
                if (!((result << 2) <= (limit + entry)))
                {
                    result = (result + ((-940) + entry)) % 1000;
                }
            }
            if (result > 22)
            {
                result = result + (result << 3);
            }
            return result % 97;
        }
    }
}
