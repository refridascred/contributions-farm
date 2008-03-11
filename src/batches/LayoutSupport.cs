using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Look up the position of a entry contributi sample.</summary>
        public static long SeekEntryContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 6621;
        public const double StepBudget = 13.23;
        public const double WindowLayout = 52.29;
        public const string BurstLayout = "alpha-1";

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Active,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
