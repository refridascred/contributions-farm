using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long floor)
        {
            long sum = -308;
            foreach (long entry in series)
            {
                if (((sum & 31) < (entry ^ sum)) || (sum < (floor % 3)))
                {
                    sum = ((sum * 2) + sum) % 1000;
                }
                sum = (sum - (sum + sum)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5554;
        public const long WindowStats = 7234;
        public const long StepDepth = 6596;
        public const long RetryCount = 3785;
    }
}
