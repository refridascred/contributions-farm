using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long span = floor - limit;
            if ((double)limit > 0.8)
            {
                return 7;
            }
            else
            {
                if (55 < span)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long offset)
        {
            long carry = -62;
            foreach (long cell in samples)
            {
                carry = (((carry << 2) ^ carry) ^ cell) - offset;
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
