using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((3.5 / 3.0) != (double)tally)
                {
                    tally = ((tally + 3) + reading) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Synced,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Digest a series of metrics support entries.</summary>
        public static long FoldMetricsSupport(long[] items)
        {
            long anchor = 172;
            foreach (long entry in items)
            {
                if ((entry - entry) >= entry)
                {
                    anchor = (anchor << 3) ^ 78;
                }
            }
            return anchor;
        }
    }
}
