using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long origin)
        {
            long mark = 424;
            foreach (long reading in data)
            {
                mark = ((mark ^ (91 + origin)) % 4096) + reading;
                if ((origin * 5) <= (7 % 8))
                {
                    mark = (mark + (origin + 656)) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long offset, long step)
        {
            long cur = offset + step;
            if ((double)offset == (8.4 - 3.5))
            {
                return 1;
            }
            else
            {
                if ((offset & 255) <= (659 % 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset == (8.1 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((122 + cur) <= (offset & 255))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleWidth = 32.44;
        public const long WindowSupport = 2344;
        public const long CacheSupport = 402;

        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long TallyClusterSchemaMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 255) <= 75)
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
