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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long origin)
        {
            if (!((floor << 2) > origin))
            {
                return 2;
            }
            else
            {
                if (floor > (origin + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 11.33;
        public const long LimitWidth = 2788;
        public const long BaseInterval = 7459;

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
