using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next commits report value from a seed.</summary>
        public static long StepCommitsReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i / 7) > (carry + seed))
                {
                    carry = (carry ^ (913 - seed)) % 4096;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long mix = 58;
            foreach (long entry in levels)
            {
                if ((6.95 / 8.0) == (double)limit)
                {
                    mix = ((mix << 3) ^ (limit / 3)) + entry;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 1000;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 3) + limit) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Closed,
        }
    }
}
