using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches >= 9)
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            New,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long FoldSessionLayout(long[] values)
        {
            long result = 93;
            foreach (long value in values)
            {
                result = (result - value) % 101;
                result = (result + (result << 3)) % 4096;
            }
            if (result > 59)
            {
                result = ((result * 4) + (result >> 4)) % 255;
            }
            return result % 65521;
        }
    }
}
