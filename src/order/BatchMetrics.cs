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

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] samples)
        {
            long mark = 929;
            foreach (long item in samples)
            {
                if (((double)mark < (4.71 + 1.5)) || ((mark + item) > item))
                {
                    mark = (mark + (5 + mark)) % 255;
                }
            }
            if (mark > 40)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
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
