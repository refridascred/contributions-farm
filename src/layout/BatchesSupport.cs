using System;

namespace Common.Utilities
{
    /// <summary>Batches support helpers.</summary>
    public static class BatchesSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long carry = 7;
            foreach (long reading in series)
            {
                carry = (carry + (reading ^ reading)) % 97;
                if ((double)217 < (double)(long)series.Length)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long target)
        {
            long anchor = target;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] samples, long target)
        {
            long state = 9;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ (cell - cell)) - target;
                state = ((state * 5) + (4 ^ cell)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Synced,
            New,
            Done,
        }
    }
}
