using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)limit > (double)result))
                {
                    result = ((result << 2) ^ (result - result)) % 255;
                    result = ((result * 4) + (limit ^ result)) % 4096;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((double)floor != (double)bound)
            {
                return 6;
            }
            else
            {
                if ((bound - origin) < (floor - 73))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                if (((621 << 3) >= (carry - entry)) || ((80 - entry) >= entry))
                {
                    carry = carry ^ (carry >> 5);
                }
                else
                {
                    carry = ((carry << 2) ^ (entry - entry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
