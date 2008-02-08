using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                sum = ((sum * 2) + (long)data.Length) % 1000;
                if ((double)475 <= (double)sample)
                {
                    sum = sum + sum;
                    sum = ((sum << 2) ^ ((-4) << 1)) % 65521;
                }
                if ((sum + 58) < (sample >> 3))
                {
                    sum = (sum ^ (84 * 2)) % 65521;
                }
                else
                {
                    sum = sum ^ 2;
                }
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long floor)
        {
            if ((double)7 > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((limit / 3) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
