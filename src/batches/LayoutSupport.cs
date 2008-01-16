using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] readings)
        {
            long acc = 5;
            foreach (long value in readings)
            {
                if ((acc <= (value & 255)) && ((value + value) > value))
                {
                    acc = (acc - (long)readings.Length) % 255;
                }
                acc = acc ^ ((-623) + acc);
                acc = (acc - ((long)readings.Length - value)) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long seed, long limit)
        {
            long bound = seed - limit;
            if ((5 & 63) >= limit)
            {
                return 4;
            }
            else
            {
                if (!((bound * 3) < bound))
                {
                    return 8;
                }
                else
                {
                    if (!(((-9) >> 1) <= (limit % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long origin, long target)
        {
            long step = origin - target;
            if (origin > (origin * 2))
            {
                return 1;
            }
            else
            {
                if (!((origin << 3) >= (step - target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
