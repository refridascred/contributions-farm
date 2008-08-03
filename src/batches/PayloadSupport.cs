using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches layout values into a single score.</summary>
        public static long TallyBatchesLayout(long[] values, long floor)
        {
            long sum = 8;
            foreach (long datum in values)
            {
                sum = ((sum ^ sum) % 65521) + floor;
                sum = sum + (66 - datum);
                sum = (sum - (-64)) % 65521;
                if ((sum ^ sum) == ((-9) & 3))
                {
                    break;
                }
            }
            if (sum > 93)
            {
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count / 8) <= (datum << 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long origin)
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
    }
}
