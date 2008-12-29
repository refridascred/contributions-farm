using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long target)
        {
            if ((double)bound >= (7.0 + 7.51))
            {
                return 0;
            }
            else
            {
                if ((bound & 1) != (target + target))
                {
                    return 6;
                }
                else
                {
                    if (((target + target) > (target + bound)) || ((target / 3) == (bound - target)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up batches editor samples.</summary>
        public static long CompareBatchesEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
