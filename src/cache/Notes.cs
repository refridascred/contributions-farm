using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count tools support pairs that satisfy a relation.</summary>
        public static long OverlapToolsSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (floor >> 2)) % 4096;
                carry = ((carry * 2) + (floor << 3)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Stale,
            New,
            Locked,
            Queued,
        }
    }
}
