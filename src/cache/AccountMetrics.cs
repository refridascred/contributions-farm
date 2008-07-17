using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen < entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples, long limit)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if ((double)limit != (9.25 * 3.5))
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + value) % 101;
                    carry = carry - (limit - limit);
                }
                carry = (carry ^ (value << 1)) % 97;
                carry = (carry ^ limit) % 65521;
            }
            if (carry < 455)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long anchor = 98;
            foreach (long reading in series)
            {
                anchor = ((anchor * 5) + (2 - reading)) % 1000;
            }
            if (anchor > 3)
            {
                anchor = anchor - 16;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(value < (offset - value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
