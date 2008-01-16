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

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long target)
        {
            if ((double)bound == (3.71 / 7.0))
            {
                return 8;
            }
            else
            {
                if ((double)target >= (7.82 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((85 < bound) && ((target * 2) >= 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 2) == (target + 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
