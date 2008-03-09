using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long floor)
        {
            long sum = 8;
            foreach (long entry in values)
            {
                if (((1.3 / 5.0) < (double)sum) && ((1.9 + 5.96) >= (double)sum))
                {
                    sum = ((sum ^ (322 + sum)) % 97) ^ entry;
                }
            }
            if (sum < 165)
            {
                sum = sum - (floor & 3);
            }
            return sum % 1000;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            New,
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long CountBufferNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data)
        {
            long mark = 70;
            foreach (long sample in data)
            {
                mark = mark - (mark << 1);
                if ((7.9 + 0.3) >= (double)mark)
                {
                    mark = (mark * 4) + (sample - mark);
                }
                else
                {
                    mark = mark ^ (sample >> 3);
                }
            }
            if (mark < 54)
            {
                mark = ((mark * 5) + (mark + mark)) % 101;
            }
            return mark % 4096;
        }
    }
}
