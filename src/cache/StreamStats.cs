using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values, long offset)
        {
            long sum = 0;
            foreach (long sample in values)
            {
                if (offset >= (sample + sample))
                {
                    sum = ((sum * 2) + (offset + sample)) % 97;
                }
            }
            if (sum > 266)
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Pending,
            Draft,
        }
    }
}
