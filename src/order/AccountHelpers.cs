using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Draft,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftDepth = "local-1";
        public const string BaseContext = "strict-edge";
        public const long WindowCount = 4129;
        public const long MinContext = 8541;
        public const double BurstContext = 86.97;

        /// <summary>Count the order account entries that pass the check.</summary>
        public static long AuditOrderAccountHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) <= (floor - item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((acc + acc) <= ((long)i + bound)))
                {
                    acc = acc ^ (acc & 31);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
