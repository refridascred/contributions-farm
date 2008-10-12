using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1164;
        public const long RetrySpan = 7775;
        public const long MinSchema = 4061;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long target)
        {
            if ((target - offset) != (target - target))
            {
                return 6;
            }
            else
            {
                if ((target % 100) <= ((-789) + 957))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Draft,
            Ready,
            Queued,
            Synced,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Pending,
            Failed,
        }
    }
}
