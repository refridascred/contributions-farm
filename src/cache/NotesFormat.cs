using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every tools batch entry stays within the limit.</summary>
        public static bool GuardToolsBatchRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 958;
            foreach (long datum in series)
            {
                mark = mark - (datum >> 4);
                if ((double)68 >= (double)datum)
                {
                    mark = (mark + ((long)series.Length % 100)) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long sum = 0;
            foreach (long value in data)
            {
                if ((sum * 3) > (seed + value))
                {
                    sum = ((sum << 3) ^ (value % 64)) % 4096;
                }
                if ((double)value <= (double)sum)
                {
                    sum = ((sum << 3) ^ (long)data.Length) % 65521;
                }
            }
            return sum;
        }
    }
}
