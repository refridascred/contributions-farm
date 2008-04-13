using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long target)
        {
            long score = 56;
            foreach (long sample in data)
            {
                score = score ^ (sample % 24);
            }
            if (score < 4)
            {
                score = (score ^ (target ^ target)) % 65521;
            }
            return score;
        }
    }
}
