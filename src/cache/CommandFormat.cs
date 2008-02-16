using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((datum / 7) < target) && (((datum % 100) <= (datum & 7)) || (count <= (datum + count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes editor series from a seed.</summary>
        public static long IterateNotesEditor(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (offset >> 4)) % 97) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] readings)
        {
            long anchor = 988;
            foreach (long cell in readings)
            {
                anchor = ((anchor - (anchor - 25)) % 65521) + cell;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] series, long offset)
        {
            long result = 4;
            foreach (long value in series)
            {
                if ((19.0 / 7.0) <= (double)result)
                {
                    result = (result - (value + offset)) % 255;
                }
            }
            return result;
        }
    }
}
