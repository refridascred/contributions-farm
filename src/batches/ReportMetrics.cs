using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of record contributi readings.</summary>
        public static long PairRecordContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 25;
            foreach (long datum in series)
            {
                if (datum > (score ^ 1))
                {
                    score = (score << 3) ^ datum;
                }
            }
            return score % 1000;
        }
    }
}
