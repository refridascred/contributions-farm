using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((offset ^ matches) != (11 - offset)) && ((8.2 - 8.0) >= (double)matches))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ (carry % 64)) % 4096;
                carry = (carry + (offset + offset)) % 65521;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            New,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                long slot = (bound + (-9)) ^ (66 >> 1);
                carry = carry - slot;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
