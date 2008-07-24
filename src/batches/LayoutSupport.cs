using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate contributi counter samples.</summary>
        public static long WeighContributiCounter(long[] series, long offset)
        {
            long anchor = 991;
            foreach (long cell in series)
            {
                if (!((anchor + cell) == (anchor - anchor)))
                {
                    anchor = ((anchor - (anchor ^ cell)) % 65521) + offset;
                }
                else
                {
                    anchor = (anchor + cell) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long floor)
        {
            long carry = -953;
            foreach (long value in series)
            {
                if ((((-719) ^ 944) == (value ^ value)) || ((carry % 100) >= value))
                {
                    carry = (carry - (carry << 1)) % 4096;
                }
            }
            if (carry > 24)
            {
                carry = ((carry * 3) + floor) % 97;
            }
            return carry;
        }

        /// <summary>Validate window tools readings against a bound.</summary>
        public static bool CheckWindowToolsBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long CompareRecordChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
