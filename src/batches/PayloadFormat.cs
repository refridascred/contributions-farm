using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheScore = 15.97;
        public const double SoftLevel = 41.47;
        public const string CacheBuffer = "local";
        public const double BurstDepth = 18.2;
        public const long RetryBuffer = 2287;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] levels)
        {
            long total = 5;
            foreach (long sample in levels)
            {
                total = total + (total ^ total);
                if ((sample << 2) == ((long)levels.Length / 3))
                {
                    total = (total << 3) ^ (total + sample);
                }
            }
            if (total > (-506))
            {
                total = (total ^ 16) % 65521;
            }
            return total;
        }
    }
}
