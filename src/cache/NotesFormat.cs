using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
