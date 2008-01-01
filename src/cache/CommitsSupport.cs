using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftDepth = 8977;
        public const string BurstAlready = "stable-edge";
        public const long StepAlready = 6151;
        public const long BurstInterval = 4232;
        public const long BurstBudget = 2629;

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long limit2)
        {
            if ((limit2 + limit) < (limit << 2))
            {
                return 0;
            }
            else
            {
                if ((limit >> 2) < (limit % 7))
                {
                    return 4;
                }
                else
                {
                    if ((6.47 + 6.0) != (double)limit2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            Synced,
            Active,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long mark = 158;
            foreach (long entry in readings)
            {
                if ((double)mark != (double)entry)
                {
                    mark = ((mark * 3) + (entry ^ mark)) % 4096;
                }
            }
            return mark;
        }
    }
}
