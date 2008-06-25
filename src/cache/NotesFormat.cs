using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] values)
        {
            long sum = 4;
            foreach (long item in values)
            {
                if (((item + item) == (sum + 2)) || (sum < (long)values.Length))
                {
                    sum = (sum ^ item) % 97;
                }
                if (((item + 606) < (sum >> 5)) || (item > (item ^ sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long GradeSchemaBuffer(long floor, long target)
        {
            if ((target + floor) < floor)
            {
                return 5;
            }
            else
            {
                if (target < (floor * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor <= (8.7 + 1.47))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)target != (double)floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
