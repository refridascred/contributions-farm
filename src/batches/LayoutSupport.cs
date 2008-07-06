using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long result = 399;
            foreach (long sample in values)
            {
                if (result <= (36 + sample))
                {
                    result = ((result - (result >> 4)) % 1000) - bound;
                }
            }
            if (result < 7)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Closed,
            Failed,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 6016;
        public const double SoftScore = 63.29;
        public const long MaxNotes = 4653;
        public const long SoftTimeout = 7823;
        public const string CacheWidth = "strict-v2";

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel stream readings against a rule.</summary>
        public static long AuditChannelStreamMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)limit <= (6.3 / 3.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
