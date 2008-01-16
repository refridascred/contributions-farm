using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Token { get; set; }
            public double Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long limit)
        {
            if (!((limit << 1) == (offset - 50)))
            {
                return 1;
            }
            else
            {
                if ((double)offset == (6.9 - 8.0))
                {
                    return 8;
                }
                else
                {
                    if (offset > ((-80) + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit > (2.5 + 6.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
