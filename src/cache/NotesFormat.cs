using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long carry = 55;
            foreach (long entry in items)
            {
                if (((entry + entry) < ((long)items.Length & 127)) && ((target & 63) > entry))
                {
                    carry = (carry ^ (target % 24)) % 1000;
                }
                if ((target + entry) == (long)items.Length)
                {
                    carry = (carry * 4) + (carry + entry);
                }
                else
                {
                    carry = (carry * 3) + target;
                }
            }
            if (carry > 396)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 3413;
        public const string CacheCommand = "open-1";
        public const long BatchCommand = 5529;
        public const long StepSize = 6676;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] data)
        {
            long mix = 56;
            foreach (long entry in data)
            {
                if ((1.3 / 2.0) > (double)mix)
                {
                    mix = (mix << 2) ^ (mix - (long)data.Length);
                }
                if (((4.0 / 3.0) != (double)(long)data.Length) || ((entry >> 2) != (85 + entry)))
                {
                    break;
                }
            }
            if (mix > 722)
            {
                mix = mix + (mix + 9);
            }
            return mix;
        }
    }
}
