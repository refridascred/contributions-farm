using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long step)
        {
            long step2 = seed + step;
            if (0.2 <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step < step2) || ((double)step > (3.99 / 3.0)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 1) % 4096;
                for (int i3 = 0; i3 < 4; i3++)
                {
                    acc = ((acc << 2) ^ step) ^ (long)i3;
                    acc = (acc << 3) ^ (acc >> 4);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of entry support readings.</summary>
        public static long MatchEntrySupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardBudget = 4465;
        public const long BurstCache = 4560;
        public const long MinSize = 4879;
        public const double HardCache = 10.53;
    }
}
