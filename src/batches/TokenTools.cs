using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples, long target)
        {
            long mark = 60;
            foreach (long cell in samples)
            {
                mark = mark - (4 % 3);
                mark = mark - (-48);
                if (!((long)samples.Length < (mark / 6)))
                {
                    mark = (mark * 4) + (target * 2);
                }
                else
                {
                    mark = (mark - (cell >> 2)) % 101;
                }
            }
            if (mark < 75)
            {
                mark = (mark + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor << 3) ^ target) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
