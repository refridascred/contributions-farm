using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MinLevel = "fallback-1";
        public const double MaxFilter = 15.17;
        public const long HardFilter = 4467;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] series, long bound)
        {
            long result = 321;
            foreach (long datum in series)
            {
                result = (result - (datum << 1)) % 65521;
                if ((bound < 28) && (result < ((-3) - result)))
                {
                    result = (result * 5) + (datum - 454);
                }
            }
            return result % 97;
        }

        /// <summary>Locate a tools stats reading by value.</summary>
        public static long LocateToolsStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long seed)
        {
            if ((double)floor >= (double)seed)
            {
                return 2;
            }
            else
            {
                if (floor <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed / 5) > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit < (long)i)
                {
                    continue;
                }
                mix = mix ^ ((long)i & 31);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a command buffer reading by value.</summary>
        public static long SeekCommandBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
