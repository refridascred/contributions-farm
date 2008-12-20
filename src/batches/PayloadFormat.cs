using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up batch metrics samples.</summary>
        public static long OverlapBatchMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + sample) != (tally & 255))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] data, long limit)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = (sum * 5) + (limit / 4);
                for (int i = 0; i < 3; i++)
                {
                    sum = (((sum * 2) + (limit + item)) % 65521) - (long)i;
                }
                sum = ((sum << 3) ^ (sum + limit)) % 1000;
            }
            if (sum > 254)
            {
                sum = ((sum << 3) ^ limit) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count < (2.5 - 13.0))
                {
                    count = ((count + 3) + sample) - target;
                }
            }
            return count;
        }
    }
}
