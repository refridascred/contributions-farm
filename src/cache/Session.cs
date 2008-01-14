using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long seed)
        {
            long score = 3;
            foreach (long entry in values)
            {
                score = ((score << 3) ^ ((long)values.Length & 3)) - entry;
                if ((seed ^ score) <= (seed >> 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Score { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
