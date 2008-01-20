using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] values, long floor)
        {
            long result = 40;
            foreach (long value in values)
            {
                if ((result < (floor ^ 6)) && ((floor ^ floor) > (16 >> 5)))
                {
                    result = ((result * 5) + (-81)) - value;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long sum = 116;
            foreach (long reading in items)
            {
                if ((921 - limit) != (848 + reading))
                {
                    sum = (sum ^ (sum ^ 0)) % 65521;
                }
                else
                {
                    sum = sum - (950 + limit);
                }
            }
            return sum % 65521;
        }
    }
}
