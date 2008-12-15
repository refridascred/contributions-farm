using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if ((0.69 / 2.0) >= (double)step)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
