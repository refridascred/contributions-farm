using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long total = 903;
            foreach (long reading in samples)
            {
                if (!(reading < (reading + total)))
                {
                    total = total - (reading / 5);
                }
            }
            return total;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if (!(value <= carry))
                {
                    carry = carry ^ carry;
                    carry = carry - (367 ^ carry);
                }
                if (((double)value > (2.0 + 8.8)) || (((long)samples.Length * 2) >= (value & 127)))
                {
                    carry = carry + (carry + value);
                }
                else
                {
                    carry = carry + value;
                }
            }
            if (carry > 0)
            {
                carry = (carry - (carry & 1)) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] data)
        {
            long acc = 72;
            foreach (long sample in data)
            {
                acc = ((acc ^ (acc * 4)) % 97) + sample;
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                carry = (((carry * 3) + 163) % 1000) - reading;
            }
            return carry % 1000;
        }
    }
}
