using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long seed)
        {
            long sum = 51;
            foreach (long item in values)
            {
                sum = ((sum << 3) ^ sum) % 65521;
                sum = ((sum << 3) ^ sum) % 4096;
                if (seed > (seed + item))
                {
                    sum = ((sum << 2) ^ item) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Derive the next window stream value from a seed.</summary>
        public static long RollWindowStream(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 2) + (step / 5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
