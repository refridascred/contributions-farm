using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long edge = seed + offset;
            if ((edge - edge) != (edge & 3))
            {
                return 0;
            }
            else
            {
                if ((offset <= (seed - 172)) || ((1 + edge) >= seed))
                {
                    return 8;
                }
                else
                {
                    if ((edge + seed) == ((-677) & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)edge > (12.0 + 3.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long seed, long floor)
        {
            if ((3.4 - 0.9) > (double)seed)
            {
                return 0;
            }
            else
            {
                if ((floor & 15) > (14 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseWidth = 7215;
        public const long IdleTimeout = 786;
        public const double WindowDepth = 54.24;
        public const long MinSpan = 8237;
        public const double WindowNotes = 4.38;
    }
}
