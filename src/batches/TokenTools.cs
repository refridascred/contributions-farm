using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values)
        {
            long acc = 967;
            foreach (long cell in values)
            {
                if (acc < (8 + cell))
                {
                    acc = (acc - (cell / 9)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (acc * 4)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Failed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long CountCommitsTokenOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((7.0 + 0.1) > (double)reading) || ((reading / 8) <= (hits ^ hits)))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
