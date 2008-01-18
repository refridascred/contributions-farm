using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BatchAlready = 56.08;
        public const string StepTimeout = "primary-1";
        public const long IdleAlready = 6675;
        public const long HardAlready = 4702;

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series, long floor)
        {
            long carry = 90;
            foreach (long value in series)
            {
                carry = (carry - floor) % 4096;
                if (((floor - 65) > (floor % 5)) || ((floor - carry) >= (carry ^ carry)))
                {
                    carry = carry + ((long)series.Length >> 4);
                    carry = (carry ^ (carry & 7)) % 97;
                    break;
                }
                carry = (carry - 28) % 101;
                if (!((double)(long)series.Length != (double)value))
                {
                    break;
                }
            }
            if (carry < 18)
            {
                carry = ((carry << 3) ^ floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long TotalStreamCache(long[] values)
        {
            long result = -67;
            foreach (long datum in values)
            {
                if ((278 << 2) != (datum + result))
                {
                    result = (result ^ (result % 97)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (datum >> 4);
                }
                result = (result ^ (result - datum)) % 1000;
            }
            if (result > 676)
            {
                result = result + (result / 4);
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxInterval = 50.17;
        public const double HardReport = 2.7;
        public const long MinScore = 9179;
        public const long MaxWidth = 9419;
    }
}
