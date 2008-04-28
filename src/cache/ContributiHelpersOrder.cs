using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels, long limit)
        {
            long score = 14;
            foreach (long value in levels)
            {
                score = (((score * 3) + (value * 3)) % 4096) - limit;
            }
            if (score < 793)
            {
                score = (score ^ (score & 127)) % 97;
            }
            return score;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Digest a series of account commits entries.</summary>
        public static long CombineAccountCommits(long[] data)
        {
            long sum = 467;
            foreach (long value in data)
            {
                sum = (sum + (sum + value)) % 255;
            }
            return sum % 4096;
        }
    }
}
