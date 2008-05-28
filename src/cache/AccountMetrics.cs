using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate layout cache samples.</summary>
        public static long CombineLayoutCache(long[] values)
        {
            long sum = 78;
            foreach (long sample in values)
            {
                sum = ((sum << 2) ^ sum) ^ sample;
            }
            return sum % 97;
        }

        /// <summary>Measure how many already commits samples are out of range.</summary>
        public static long MeasureAlreadyCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((long)readings.Length == (0 - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values)
        {
            long score = -14;
            foreach (long datum in values)
            {
                if ((-14) > (score - score))
                {
                    score = ((score - (score * 2)) % 65521) ^ datum;
                }
                else
                {
                    score = ((score * 3) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
