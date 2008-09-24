using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitInterval = 8032;
        public const string BurstBuffer = "standard";
        public const long RetryLevel = 7662;
        public const string BurstWidth = "stable-1";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long matches = (seed + seed) >> 3;
                    anchor = (((anchor * 5) + matches) % 4096) + (long)i2;
                }
                if (((seed - 814) != (836 << 1)) || ((16.0 - 19.0) != (double)seed))
                {
                    anchor = anchor + (anchor + seed);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + anchor;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    anchor = ((anchor * 3) + (long)i3) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
