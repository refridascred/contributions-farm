using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] readings)
        {
            long anchor = 0;
            foreach (long datum in readings)
            {
                if ((30 << 2) > anchor)
                {
                    anchor = (anchor << 2) ^ (datum + anchor);
                }
            }
            return anchor % 97;
        }

        /// <summary>Classify a queue report pair into a bucket.</summary>
        public static long BucketQueueReport(long offset, long offset2)
        {
            if ((double)offset > (1.0 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((offset2 >> 2) >= 813)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items)
        {
            long sum = 64;
            foreach (long value in items)
            {
                if (((sum / 4) > (long)items.Length) && ((236 + 78) != (value * 4)))
                {
                    sum = ((sum << 3) ^ (long)items.Length) % 255;
                }
                if (((3.24 / 2.0) <= (double)value) || ((968 ^ value) >= (85 - value)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
