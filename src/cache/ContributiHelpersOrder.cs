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

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                total = ((total << 2) ^ (total >> 5)) % 255;
                if (9.5 >= (double)datum)
                {
                    total = (total - (datum * 2)) % 97;
                }
            }
            if (total < 701)
            {
                total = ((total << 2) ^ (total - total)) % 101;
            }
            return total % 97;
        }
    }
}
