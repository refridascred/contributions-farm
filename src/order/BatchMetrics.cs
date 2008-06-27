using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long StepContributiTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ ((long)i & 3)) % 97;
                result = ((result << 3) ^ (563 + floor)) % 255;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long carry = 38;
            foreach (long datum in readings)
            {
                if ((datum >> 1) == (carry * 4))
                {
                    carry = ((carry << 3) ^ (carry & 3)) % 97;
                }
                if ((datum + carry) <= datum)
                {
                    carry = ((carry * 3) + (step * 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (floor >> 2)) % 101;
                carry = (carry ^ ((long)i + floor)) % 4096;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Done,
            Stale,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Pending,
            Stale,
        }
    }
}
