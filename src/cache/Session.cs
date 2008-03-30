using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every batches stream entry stays within the limit.</summary>
        public static bool ValidateBatchesStreamRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items)
        {
            long score = 53;
            foreach (long sample in items)
            {
                if ((sample / 7) != (503 + (-82)))
                {
                    score = ((score << 3) ^ (sample / 4)) % 4096;
                }
            }
            if (score > 0)
            {
                score = (score ^ ((-84) % 100)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 34;
            foreach (long item in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = (mark * 4) + (14 / 6);
                mark = mark - (item << 2);
            }
            return mark % 97;
        }
    }
}
