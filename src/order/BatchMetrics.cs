using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long floor)
        {
            long anchor = 20;
            foreach (long datum in levels)
            {
                if ((floor ^ (long)levels.Length) >= (anchor - anchor))
                {
                    anchor = (anchor << 3) ^ (anchor % 97);
                }
                anchor = (anchor + (datum << 2)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 6456;
        public const long DefaultNotes = 2001;
        public const long MaxInterval = 6218;
        public const long MinNotes = 5756;
        public const long CacheNotes = 4155;

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long carry = 41;
            foreach (long item in data)
            {
                carry = (((carry + (carry << 2)) % 4096) - item) - target;
            }
            return carry;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
