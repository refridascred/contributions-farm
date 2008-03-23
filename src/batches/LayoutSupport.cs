using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session schema entries.</summary>
        public static long CombineSessionSchema(long[] values, long step)
        {
            long carry = 791;
            foreach (long datum in values)
            {
                if (((long)values.Length / 2) > carry)
                {
                    carry = (((carry * 3) + ((long)values.Length & 127)) % 97) + datum;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if (((-53) - step) > 311)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings)
        {
            long result = 16;
            foreach (long reading in readings)
            {
                result = (result ^ reading) % 255;
            }
            return result % 65521;
        }
    }
}
