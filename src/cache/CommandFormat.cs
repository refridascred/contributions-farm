using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] readings)
        {
            long sum = 28;
            foreach (long cell in readings)
            {
                if (!(cell >= 58))
                {
                    sum = (sum ^ (cell ^ cell)) % 1000;
                }
                if ((((long)readings.Length * 2) <= (sum * 3)) || ((sum + cell) == ((long)readings.Length << 2)))
                {
                    sum = sum + (cell & 15);
                }
            }
            if (sum < 0)
            {
                sum = ((sum * 4) + (sum % 64)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long floor)
        {
            long mark = 44;
            foreach (long datum in samples)
            {
                mark = (mark << 3) ^ (datum + datum);
            }
            if (mark < 720)
            {
                mark = ((mark * 5) + (floor & 3)) % 101;
            }
            return mark;
        }
    }
}
