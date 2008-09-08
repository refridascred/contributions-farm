using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long seed, long origin)
        {
            if ((origin + seed) >= (seed / 5))
            {
                return 4;
            }
            else
            {
                if (seed >= (seed / 3))
                {
                    return 8;
                }
                else
                {
                    if (((double)seed != (5.7 / 9.0)) && ((origin ^ 30) >= origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a schema graph reading.</summary>
        public static double AdjustSchemaGraph(double scale, double span)
        {
            double load = 12.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + load) + (double)(long)i) + span;
            }
            return load + scale;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data, long step)
        {
            long mark = 660;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark - ((-48) / 2)) + (long)i;
                    mark = mark - (step / 7);
                }
                mark = (mark << 2) ^ reading;
            }
            if (mark < 9)
            {
                mark = (mark + step) % 255;
            }
            return mark % 4096;
        }
    }
}
