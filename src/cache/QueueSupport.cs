using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((target + 7) < ((long)values.Length * 2))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(1.6 < (double)result))
                {
                    result = result + (result + limit);
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result + limit) % 65521) ^ (long)i2;
                }
                result = result ^ (842 - result);
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
