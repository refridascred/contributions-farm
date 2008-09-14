using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target & 15) <= (state + (long)i))
                {
                    continue;
                }
                else
                {
                    state = state + (946 + target);
                }
                state = ((state << 3) ^ 172) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1518;
        public const string MaxOrder = "primary";
        public const long BatchTimeout = 6405;
        public const double StepOrder = 45.84;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats farm series from a seed.</summary>
        public static long RollStatsFarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if (total < (long)i)
                {
                    total = total ^ (origin + (long)i);
                    continue;
                }
                if (total > origin)
                {
                    total = (total + total) % 4096;
                    total = (total * 5) + (origin + origin);
                }
                if (((9.0 / 5.0) > (double)origin) || ((9.0 + 8.17) != (double)(long)i))
                {
                    long seen = (total + origin) - total;
                    total = ((total * 5) + (origin + seen)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long bound, long seed)
        {
            if ((double)bound >= (12.0 - 6.64))
            {
                return 7;
            }
            else
            {
                if (seed >= (bound - 833))
                {
                    return 3;
                }
                else
                {
                    if (((bound >> 3) > (79 + 118)) && ((double)seed >= (4.31 / 8.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
