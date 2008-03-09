using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 2) ^ (result / 9)) % 255;
                if ((offset & 127) < 292)
                {
                    long next = (offset % 12) + (3 + offset);
                    result = ((result << 3) ^ (next + (long)i)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many order account samples are out of range.</summary>
        public static long CountOrderAccountGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (seen >= datum)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long bound, long target)
        {
            long step = bound + target;
            if (step <= (bound >> 4))
            {
                return 3;
            }
            else
            {
                if ((3.63 * 10.0) != (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
