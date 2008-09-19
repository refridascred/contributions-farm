using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long ScoreMetricsCluster(long[] values, long offset)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if (8 < (offset % 64))
                {
                    carry = (carry ^ offset) % 101;
                }
                if ((offset / 3) > (offset ^ entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Offset { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long bound2)
        {
            if ((bound2 - bound) < (bound2 & 255))
            {
                return 7;
            }
            else
            {
                if (bound2 < (bound % 100))
                {
                    return 2;
                }
                else
                {
                    if (!((2.5 + 7.99) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 2932;
        public const long HardSize = 4508;
        public const long BaseLevel = 1019;
    }
}
