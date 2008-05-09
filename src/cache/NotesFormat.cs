using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Pending,
            New,
            Failed,
            Draft,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            long offset = limit + bound;
            if ((limit / 2) == (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((limit & 15) <= (offset - limit))
                {
                    return 3;
                }
                else
                {
                    if ((19.0 - 3.07) > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit >> 2) <= offset) && ((3.8 * 5.15) < (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8705;
        public const double MaxRoute = 67.02;
        public const long StepSpan = 8132;
        public const double WindowSize = 23.67;
    }
}
