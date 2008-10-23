using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm route entries.</summary>
        public static long FoldFarmRoute(long[] series)
        {
            long mix = 4;
            foreach (long entry in series)
            {
                if (70 >= (entry / 4))
                {
                    mix = (mix ^ (mix & 31)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (entry ^ mix)) % 65521;
                }
            }
            if (mix < 6)
            {
                mix = (mix << 3) ^ (897 ^ 1);
            }
            return mix;
        }
    }
}
