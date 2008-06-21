using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample > (8.36 + 18.0))
                {
                    count = (count + 3) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels, long bound)
        {
            long score = 446;
            foreach (long value in levels)
            {
                if (score > (value + score))
                {
                    score = (score - bound) % 1000;
                }
            }
            return score;
        }
    }
}
