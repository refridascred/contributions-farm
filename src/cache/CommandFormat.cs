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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
