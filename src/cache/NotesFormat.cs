using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long floor, long bound)
        {
            if (((17.0 - 3.2) > (double)bound) || ((floor >> 5) >= (floor + 61)))
            {
                return 0;
            }
            else
            {
                if (floor >= (floor ^ (-80)))
                {
                    return 4;
                }
                else
                {
                    if ((bound >= (floor * 2)) && (floor <= (67 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound >= (12.0 * 1.2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Token { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
