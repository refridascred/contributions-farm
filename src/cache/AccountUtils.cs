using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long floor, long target)
        {
            if (2.46 <= (double)floor)
            {
                return 8;
            }
            else
            {
                if (11.0 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if (10.0 > (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor / 8) < (floor & 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
