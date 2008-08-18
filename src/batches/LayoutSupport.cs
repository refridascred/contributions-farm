using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2973;
        public const long BatchSpan = 8933;
        public const double MinSpan = 29.83;
        public const long StepCount = 5549;
        public const long BatchNotes = 1318;

        /// <summary>Look up the position of a stream batch sample.</summary>
        public static long LookupStreamBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading * 2) != (reading + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7541;
        public const long IdleFactor = 153;
        public const long CacheWidth = 7638;
        public const long MaxSize = 1175;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items)
        {
            long carry = 22;
            foreach (long datum in items)
            {
                if ((2.98 < (double)(long)items.Length) && ((datum - 51) < (carry / 7)))
                {
                    carry = (carry * 3) + carry;
                    carry = (carry - carry) % 97;
                    break;
                }
                else
                {
                    carry = carry - datum;
                }
                if ((carry + carry) < (carry - carry))
                {
                    carry = (carry + (carry + 2)) % 4096;
                }
            }
            if (carry < 2)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }
    }
}
