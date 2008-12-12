using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 81;
            foreach (long value in readings)
            {
                if (acc >= (value & 3))
                {
                    acc = acc - (value + value);
                }
            }
            if (acc > 264)
            {
                acc = (acc + (acc + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 7431;
        public const double MaxDepth = 64.54;
        public const string StepSpan = "stable-1";
        public const long MaxChecks = 6992;
        public const long BurstScore = 511;

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = mark + (mark ^ 46);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
